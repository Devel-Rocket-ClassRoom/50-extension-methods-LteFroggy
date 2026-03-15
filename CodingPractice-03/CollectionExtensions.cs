using System;
using System.Collections.Generic;

static class CollectionExtensions {
    public static bool IsEmpty<T>(this ICollection<T> list) {
        return list.Count == 0;
    }

    public static bool HasItems<T>(this ICollection<T> list) {
        return list.Count > 0;
    }

    public static void ForEach<T>(this IEnumerable<T> list, Action<T> action) {
        foreach (var item in list) {
            action(item);
        }
    }
}