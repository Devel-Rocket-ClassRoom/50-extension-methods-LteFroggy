using System;

static class StringChainExtensions {
    public static string AddPrefix(this string str, string prefix) {
        str = prefix + str;
        return str;
    }

    public static string AddSuffix(this string str, string suffix) {
        str = str + suffix;
        return str;
    }

    public static string Take(this string str, int count) {
        str = str.Substring(0, count);
        return str;
    }

    public static string AddEllipsis(this string str) {
        str = str + "...";
        return str;
    }
}