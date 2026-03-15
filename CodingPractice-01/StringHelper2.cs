using System;

static class StringHelper2 {
    public static int CountWords(this string text) {
        return text.Split(' ').Length;
    }
}