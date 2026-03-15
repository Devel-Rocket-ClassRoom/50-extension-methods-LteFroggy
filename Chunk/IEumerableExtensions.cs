using System;
using System.Collections.Generic;

static class IEnumerableExtensions {
    public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> enumerable, int size) {
        if (size < 1) {
            throw new ArgumentException();
        }

        // enumerable을 size개씩 분해.
        List<T> chunk = new List<T>();

        foreach (var item in enumerable) {
            if (chunk.Count == size) {
                yield return chunk;
                chunk = new List<T>(new T[] { item });
            } else {
                chunk.Add(item);
            }
        }
        yield return chunk;
    }
}