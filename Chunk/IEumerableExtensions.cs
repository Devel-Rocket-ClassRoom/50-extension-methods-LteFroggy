using System;
using System.Collections.Generic;

static class IEnumerableExtensions {
    public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> enumerable, int size) where T : new() {
        if (size < 1) {
            throw new ArgumentException();
        }

        // enumerable을 size개씩 분해.
        List<T> chunk = new List<T>();

        List<T> tempVal = new List<T>();
        foreach (var item in enumerable) {
            if (chunk.Count == size) {
                yield return tempVal;
                tempVal = new List<T>();
            } else {
                tempVal.Add(item);
            }
        }
    }
}