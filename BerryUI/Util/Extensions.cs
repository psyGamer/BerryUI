using System.Collections.Generic;
using System.IO;

namespace BerryUI.Util;

public static class Extensions {
    public static void RemoveUnordered<T>(this List<T> list, T item) {
        int end = list.Count - 1;
        int index = list.IndexOf(item);
        list[index] = list[end];
        list.RemoveAt(end);
    }
    public static void RemoveAtUnordered<T>(this List<T> list, int index) {
        int end = list.Count - 1;
        list[index] = list[end];
        list.RemoveAt(end);
    }

    public static byte[] ToByteArray(this Stream stream) {
        using var ms = new MemoryStream();
        stream.CopyTo(ms);
        return ms.ToArray();
    }
}
