using System;

static class StringExtensions {
    public static string First(this string text, int count) {
        if (string.IsNullOrEmpty(text)) {
            return text;
        } else if (text.Length <= count) {
            return text;
        } else {
            return text.Substring(0, count);
        }
    }
}