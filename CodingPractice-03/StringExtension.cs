using System;

static class StringExtension {
    public static bool IsCapitalized(this string str) {
        return str[0] >= 'A' && str[0] <= 'Z';
    }

    public static string Capitalize(this string str) {
        return str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();
    }

    public static string Reverse(this string str) {
        var chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}