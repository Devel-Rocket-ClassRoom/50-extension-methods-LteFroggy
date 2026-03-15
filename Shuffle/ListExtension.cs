using System;
using System.Collections.Generic;

static class ListExtension {
    public static void Shuffle<T> (this IList<T> list) {
        Random rand = new Random();

        for (int i = list.Count - 1; i > 0; i--) {
            int loc = rand.Next(i - 1);
            T tmp = list[i];
            list[i] = list[loc];
            list[loc] = tmp;
        }
    }
}