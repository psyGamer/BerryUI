using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace BerryUI.Util;

public static class CollectionUtils {
    /// Ensures the array hash at least the specified capacity.
    /// Invalidates all data stored inside the array
    public static void EnsureArrayCapacityInvalidate<T>(ref T[] array, int capacity) {
        // Super-linear growth factor of 1.5x
        if (array.Length < capacity) {
            array = new T[capacity + capacity / 2];
        }
    }
    /// Ensures the array hash at least the specified capacity.
    /// Copies the existing data over, while keeping the new data uninitialized.
    public static void EnsureArrayCapacityKeep<T>(ref T[] array, int capacity) {
        // Super-linear growth factor of 1.5x
        if (array.Length < capacity) {
            Array.Resize(ref array, capacity + capacity / 2);
        }
    }

    /// Compares both values with the provided context and returns whether true, iff lhs is less than rhs.
    public delegate bool ContextComparison<in TKey, in TContext>(TKey lhs, TKey rhs, TContext context)
        where TKey : allows ref struct
        where TContext : allows ref struct;

    /// Sorts the elements of this collection, while providing the comparision function with a shared context
    public static void SortWithContext<TKey, TContext>(this Span<TKey> keys, in TContext context, ContextComparison<TKey, TContext> lessThan) where TContext : allows ref struct {
        // NOTE: Implementation based upon .NET's ArraySortHelper: https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/Collections/Generic/ArraySortHelper.cs
        if (keys.Length == 0) {
            return;
        }

        // This is the threshold where Introspective sort switches to Insertion sort.
        // Empirically, 16 seems to speed up most cases without slowing down others, at least for integers.
        // Large value types may benefit from a smaller number.
        const int IntrosortSizeThreshold = 16;

        IntroSort(keys, context, 2 * (BitOperations.Log2((uint)keys.Length) + 1), lessThan);
        return;

        // IntroSort is recursive; block it from being inlined into itself as this is currently not profitable.
        [MethodImpl(MethodImplOptions.NoInlining)]
        static void IntroSort(Span<TKey> keys, in TContext context, int depthLimit, ContextComparison<TKey, TContext> lessThan) {
            Debug.Assert(!keys.IsEmpty);
            Debug.Assert(depthLimit >= 0);

            int partitionSize = keys.Length;
            while (partitionSize > 1) {
                if (partitionSize <= IntrosortSizeThreshold) {
                    if (partitionSize == 2) {
                        SwapIfGreater(keys, context, lessThan, 0, 1);
                        return;
                    }

                    if (partitionSize == 3) {
                        SwapIfGreater(keys, context, lessThan, 0, 1);
                        SwapIfGreater(keys, context, lessThan, 0, 2);
                        SwapIfGreater(keys, context, lessThan, 1, 2);
                        return;
                    }

                    InsertionSort(keys.Slice(0, partitionSize), context, lessThan);
                    return;
                }

                if (depthLimit == 0) {
                    HeapSort(keys.Slice(0, partitionSize), context, lessThan);
                    return;
                }

                depthLimit--;

                int p = PickPivotAndPartition(keys.Slice(0, partitionSize), context, lessThan);

                // Note we've already partitioned around the pivot and do not have to move the pivot again.
                IntroSort(keys[(p + 1)..partitionSize], context, depthLimit, lessThan);
                partitionSize = p;
            }
        }

        static int PickPivotAndPartition(Span<TKey> keys, in TContext context, ContextComparison<TKey, TContext> lessThan) {
            Debug.Assert(keys.Length >= IntrosortSizeThreshold);
            Debug.Assert(lessThan != null);

            int hi = keys.Length - 1;

            // Compute median-of-three.  But also partition them, since we've done the comparison.
            int middle = hi >> 1;

            // Sort lo, mid and hi appropriately, then pick mid as the pivot.
            SwapIfGreater(keys, context, lessThan, 0, middle); // swap the low with the mid point
            SwapIfGreater(keys, context, lessThan, 0, hi); // swap the low with the high
            SwapIfGreater(keys, context, lessThan, middle, hi); // swap the middle with the high

            var pivot = keys[middle];
            Swap(keys, middle, hi - 1);
            int left = 0, right = hi - 1; // We already partitioned lo and hi and put the pivot in hi - 1.  And we pre-increment & decrement below.

            while (left < right) {
                while (lessThan(keys[++left], pivot, context)) ;
                while (lessThan(pivot, keys[--right], context)) ;

                if (left >= right)
                    break;

                Swap(keys, left, right);
            }

            // Put pivot in the right location.
            if (left != hi - 1) {
                Swap(keys, left, hi - 1);
            }

            return left;
        }

        static void HeapSort(Span<TKey> keys, in TContext context, ContextComparison<TKey, TContext> lessThan) {
            Debug.Assert(lessThan != null);
            Debug.Assert(!keys.IsEmpty);

            int n = keys.Length;
            for (int i = n >> 1; i >= 1; i--) {
                DownHeap(keys, context, i, n, lessThan);
            }

            for (int i = n; i > 1; i--) {
                Swap(keys, 0, i - 1);
                DownHeap(keys, context, 1, i - 1, lessThan);
            }
        }

        static void DownHeap(Span<TKey> keys, in TContext context, int i, int n, ContextComparison<TKey, TContext> lessThan) {
            Debug.Assert(lessThan != null);

            var d = keys[i - 1];
            while (i <= n >> 1) {
                int child = 2 * i;
                if (child < n && lessThan(keys[child - 1], keys[child], context)) {
                    child++;
                }

                if (!lessThan(d, keys[child - 1], context))
                    break;

                keys[i - 1] = keys[child - 1];
                i = child;
            }

            keys[i - 1] = d;
        }

        static void InsertionSort(Span<TKey> keys, in TContext context, ContextComparison<TKey, TContext> lessThan) {
            for (int i = 0; i < keys.Length - 1; i++) {
                var t = keys[i + 1];

                int j = i;
                while (j >= 0 && lessThan(t, keys[j], context)) {
                    keys[j + 1] = keys[j];
                    j--;
                }

                keys[j + 1] = t;
            }
        }

        static void SwapIfGreater(Span<TKey> keys, in TContext context, ContextComparison<TKey, TContext> lessThan, int i, int j) {
            Debug.Assert(i != j);

            if (lessThan(keys[j], keys[i], context)) {
                TKey key = keys[i];
                keys[i] = keys[j];
                keys[j] = key;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static void Swap(Span<TKey> keys, int i, int j) {
            Debug.Assert(i != j);

            TKey t = keys[i];
            keys[i] = keys[j];
            keys[j] = t;
        }
    }
}
