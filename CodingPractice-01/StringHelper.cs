using System;

static class StringHelper {

    public static int CountWords(string text) {
        return text.Split(' ').Length;
    }

}