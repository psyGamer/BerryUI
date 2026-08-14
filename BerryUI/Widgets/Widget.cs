using BerryUI.Render;
using System;

namespace BerryUI;

/// The base class of all UI widgets.
public abstract class Widget {
    public USize MinimumSize;
    public URect ContentRect;

    public readonly WidgetCollection Children;
    public Widget? Parent { get; internal set; }

    public bool NeedsLayout = true;
    public bool NeedsDraw = true;

    protected Widget() {
        Children = new WidgetCollection(this);
    }

    /// Unique depth layer at which this widget is rendered at
    public uint Depth { get; internal set; }
    internal uint nextDepth;

    public virtual void ResolveLayout() {
        foreach (var child in Children) {
            if (child.NeedsLayout) {
                child.NeedsLayout = false;
                child.ResolveLayout();

                // If a child wants another layout resolution, then we'll need one as well
                NeedsLayout |= child.NeedsLayout;
            }
        }
    }

    /// Encodes the commands required to draw this widget.
    /// The provided <see cref="drawRegion"/> can be used to avoid re-drawing unchanged content.
    /// It is important to clear the <see cref="NeedsDraw"/> flag to avoid redrawing every frame.
    public virtual void Draw(CommandEncoder enc, URect drawRegion) {
        NeedsDraw = false;
        enc.Depth = Depth;

        foreach (var child in Children) {
            child.Draw(enc, drawRegion);
        }
    }

    /// Reports whether the region inside the current widget is rendered fully opaque.
    /// This guarantees the renderer, that every pixel inside will be covered by a <see cref="CmdSprite"/> with alpha 0xFF.
    /// Otherwise, it will be assumed that the <see cref="Parent"/> widget below is visible within this region.
    public virtual bool IsRegionOpaque(URect region) {
        return true;
    }

    /// Checks if any content of this widget is out-of-date and re-draws everything accordingly.
    /// Returns true when the widget cannot draw itself independently (e.g. it has semi-transparency).
    internal bool CheckDraw(CommandEncoder enc, out URect drawRegion) {
        if (NeedsDraw) {
            // Skip checking children since they are forced to re-draw anyway
            drawRegion = ContentRect;

            if (IsRegionOpaque(drawRegion)) {
                // We can just render ourselves
                Draw(enc, drawRegion);
                return false;
            }

            // Dispatch to our parent to handle the transparency
            return true;
        }

        drawRegion = URect.Max;

        bool anyChildNeedsDraw = false;
        Span<bool> childNeedsDraw = stackalloc bool[Children.Count];
        Span<URect> childDrawRegion = stackalloc URect[Children.Count];

        for (int idx = 0; idx < Children.Count; idx++) {
            var child = Children[idx];
            childNeedsDraw[idx] = child.CheckDraw(enc, out childDrawRegion[idx]);
            anyChildNeedsDraw |= childNeedsDraw[idx];

            if (!childNeedsDraw[idx]) {
                continue;
            }

            drawRegion = URect.Combine(drawRegion, childDrawRegion[idx]);
        }

        if (!anyChildNeedsDraw) {
            // Nothing to draw
            return false;
        }

        // We have semi-transparent children, which means we need to traverse upwards,
        // until we hit something which provides an opaque background.
        if (IsRegionOpaque(drawRegion)) {
            // We can provide the opaque background ourselves
            Draw(enc, drawRegion);
            return false;
        }

        // Dispatch to our parent to handle the transparency
        return true;
    }

    /// Recursively recalculates the depth of all children, based on the current depth of this widget.
    internal void RecalculateDepth() {
        nextDepth = Depth + 1;
        foreach (var child in Children) {
            child.Depth = nextDepth;
            child.RecalculateDepth();
            nextDepth = child.nextDepth;
        }
    }

    public void RequestLayout() {
        for (var widget = this; widget is not null; widget = widget.Parent) {
            widget.NeedsLayout = true;
        }
    }
    public void InvalidateLayout() {
        RequestLayout();
        InvalidateContentLayout();
    }
    public void InvalidateContentLayout() {
        foreach (var child in Children) {
            child.NeedsLayout = true;
            child.InvalidateContentLayout();
        }
    }
}
