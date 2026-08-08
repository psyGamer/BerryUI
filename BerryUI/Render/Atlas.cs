using BerryUI.Util;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BerryUI.Render;

/// Texture atlas which allows for efficiently packing textures inside it.
public class Atlas(uint pageSize, uint padding) : IDisposable {
    public struct Entry(USize size) {
        internal URect Region = new(UPoint.Zero, size);
        internal int PageIndex = -1;
    }

    private readonly struct Page {
        public readonly Texture Texture;
        public readonly List<URect> Free = [];

        public Page(uint size) {
            Texture = new Texture(size, size);
            Free.Add(new URect(0, 0, size, size));
        }

        public URect? Place(USize size) {
            // Try to find the best free area
            int bestIndex = -1;
            URect bestRect = default;
            for (int i = 0; i < Free.Count; i++) {
                var rect = Free[i];
                if (size.Width > rect.Width || size.Height > rect.Height) {
                    // Doesn't fit
                    continue;
                }

                if (rect.Size == size) {
                    // Perfect fit
                    Free.RemoveAtUnordered(i);
                    return rect;
                }

                if (
                    // Check for first match
                    bestIndex == -1 ||
                    // Check for smaller area
                    (rect.Width <= bestRect.Width && rect.Height <= bestRect.Height) ||
                    // Check for smaller size along short edge
                    (size.Width < size.Height
                        ? rect.Width <= bestRect.Width // Prioritize small width for tall region
                        : rect.Height <= bestRect.Height)  // Prioritize small height for wide region
                ) {
                    bestIndex = i;
                    bestRect = rect;
                }
            }

            if (bestIndex == -1) {
                // Not enough space
                return null;
            }

            // Subdivide claimed area
            var taken = new URect(bestRect.Point, size);
            URect freeR, freeD;

            if (size.Width < size.Height) {
                /* +-------+-------+
                   | Taken | FreeR |
                   |       |       |
                   |       |       |
                   |       |       |
                   +-------+       |
                   | FreeD |       |
                   +-------+-------+ */

                freeR = URect.FromEdges(left: taken.Right, right: bestRect.Right, top: bestRect.Top, bottom: bestRect.Bottom);
                freeD = URect.FromEdges(left: bestRect.Left, right: taken.Right, top: taken.Bottom, bottom: bestRect.Bottom);
            } else {
                /* +-----------+---------------+
                   |   Taken   |     FreeR     |
                   +-----------+---------------+
                   |           FreeD           |
                   +-----------+---------------+ */

                freeR = URect.FromEdges(left: taken.Right, right: bestRect.Right, top: bestRect.Top, bottom: taken.Bottom);
                freeD = URect.FromEdges(left: bestRect.Left, right: bestRect.Right, top: taken.Bottom, bottom: bestRect.Bottom);
            }

            bool canReplace = true;
            if (freeR is { Width: > 0, Height: > 0 }) {
                if (canReplace) {
                    canReplace = false;
                    Free[bestIndex] = freeR;
                } else {
                    Free.Add(freeR);
                }
            }
            if (freeD is { Width: > 0, Height: > 0 }) {
                if (canReplace) {
                    canReplace = false;
                    Free[bestIndex] = freeD;
                } else {
                    Free.Add(freeD);
                }
            }

            if (canReplace) {
                Free.RemoveAtUnordered(bestIndex);
            }

            return taken;
        }
    }

    /// Width/Height of the used backing textures.
    /// For best GPU compatibility, this should ideally be a power of two, not larger than 4096.
    public readonly uint PageSize = pageSize;
    /// Padding between the individual entries to avoid pixel bleeding.
    public readonly uint Padding = padding;

    private readonly List<Page> pages = [];
    private readonly List<Entry> entries = [];
    private int packStartEntry;

    /// Adds a new entry to this atlas.
    /// <see cref="PackEntries"/> has to be called, before calls to <see cref="GetTexture"/> are valid for this handle.
    /// The size of the region may not exceed the specified <see cref="PageSize"/>.
    public ResourceHandle<Entry> Add(USize size) {
        if (size.Width > PageSize || size.Height > PageSize) {
            throw new Exception("Region is larger than max atlas size");
        }

        var handle = new ResourceHandle<Entry>((uint)entries.Count);
        entries.Add(new Entry(new USize(size.Width + Padding, size.Height + Padding)));
        return handle;
    }

    /// Provides the texture view into the packe target location
    public Texture GetTexture(ResourceHandle<Entry> handle) {
        var entry = entries[(int)handle.Value];
        var page = pages[entry.PageIndex];

        return page.Texture.GetSubregion(entry.Region);
    }

    /// Packs newly added entries into the atlas, without touching existing entries
    public void PackAdded() {
        PackEntries(CollectionsMarshal.AsSpan(entries)[packStartEntry..]);
        packStartEntry = entries.Count;
    }
    /// Packs all entries inside the atlas
    public void PackAll() {
        // Reset pages
        foreach (var page in pages) {
            page.Free.Clear();
            page.Free.Add(new URect(0, 0, PageSize, PageSize));
        }

        PackEntries(CollectionsMarshal.AsSpan(entries));
        packStartEntry = entries.Count;
    }

    private void PackEntries(Span<Entry> toPack) {
        if (toPack.IsEmpty) {
            return;
        }

        // Create index lookup to avoid changing order of entries
        var indices = new (int Index, uint Area)[toPack.Length];
        for (int i = 0; i < indices.Length; i++) {
            indices[i] = (Index: i, Area: toPack[i].Region.Width * toPack[i].Region.Height);
        }

        // Sort from largest to smallest
        indices.Sort((a, b) => (int)(b.Area - a.Area));

        uint halfPadding = Padding / 2;
        foreach (var index in indices) {
            ref var entry = ref toPack[index.Index];
            var entrySize = entry.Region.Size;

            for (int pageIdx = 0; pageIdx < pages.Count; pageIdx++) {
                var page = pages[pageIdx];

                if (page.Place(entrySize) is { } region) {
                    entry.PageIndex = pageIdx;
                    entry.Region = region;
                    entry.Region.X += halfPadding;
                    entry.Region.Y += halfPadding;
                    entry.Region.Width -= Padding;
                    entry.Region.Height -= Padding;
                    goto NextEntry;
                }
            }

            {
                var page = new Page(PageSize);
                entry.PageIndex = pages.Count;
                entry.Region = page.Place(entrySize)!.Value;
                entry.Region.X += halfPadding;
                entry.Region.Y += halfPadding;
                entry.Region.Width -= Padding;
                entry.Region.Height -= Padding;
                pages.Add(page);
            }

            NextEntry:;
        }
    }

    public void Dispose() {
        foreach (var page in pages) {
            page.Texture.Dispose();
        }
    }
}
