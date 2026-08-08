using System;
using System.Collections;
using System.Collections.Generic;

namespace BerryUI.Util;

/// Unique numeric identifier for a resource.
/// The actual value is implementation-specific.
public readonly record struct ResourceHandle<T>(uint Value) {
    private const uint FlagReference = 1u << 31;

    /// Indices that this handle is a 'reference' and doesn't own the data associated with it.
    public bool IsReference => (Value & FlagReference) == FlagReference;

    /// Copies the handle with the 'reference' flag set.
    public ResourceHandle<T> CreateRef() {
        return new(Value | FlagReference);
    }
}

/// Resource pool which allows implementations to easily associate backing types with a respective handle.
public sealed class ResourcePool<TFrontend, TBackend> : IEnumerable<TBackend> where TBackend : class, IDisposable {
    private readonly List<TBackend?> pool = [];
    private int lastIndex = -1;

    public TBackend this[ResourceHandle<TFrontend> handle] => pool[(int)handle.Value]!;

    public ResourceHandle<TFrontend> Allocate(TBackend entry) {
        var handle = AllocateSlot();
        pool[lastIndex] = entry;
        return handle;
    }
    public ResourceHandle<TFrontend> AllocateSlot() {
        // Search for a free slot
        for (lastIndex++; lastIndex < pool.Count; lastIndex++) {
            if (pool[lastIndex] is null) {
                return new((uint)lastIndex);
            }
        }

        // Allocate a new slot
        pool.Add(null);
        return new((uint)lastIndex);
    }

    public void Free(ResourceHandle<TFrontend> handle) {
        lastIndex = (int)handle.Value;

        pool[lastIndex]!.Dispose();
        pool[lastIndex] = null;
    }

    IEnumerator IEnumerable.GetEnumerator() => new Enumerator(pool);
    IEnumerator<TBackend> IEnumerable<TBackend>.GetEnumerator() => new Enumerator(pool);

    private struct Enumerator(List<TBackend?> pool) : IEnumerator<TBackend> {
        private List<TBackend?>.Enumerator poolEnumerator = pool.GetEnumerator();

        public bool MoveNext() {
            while (poolEnumerator.MoveNext()) {
                if (poolEnumerator.Current != null) {
                    return true;
                }
            }

            return false;
        }

        object? IEnumerator.Current => poolEnumerator.Current;
        public TBackend Current => poolEnumerator.Current!;

        public void Dispose() => poolEnumerator.Dispose();
        void IEnumerator.Reset() => ((IEnumerator)poolEnumerator).Reset();
    }
}
