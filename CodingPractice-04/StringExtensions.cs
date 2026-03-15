using System;
using System.Collections.Generic;

public static class StringExtensions
{
    public static string Upper(this string text) {
        return text.ToUpper();
    }

    public static string Trim(this string text) {
        return text.Trim();
    }

    public static string Replace(this string text, char oldChar, char newChar) {
        return text.Replace(oldChar, newChar);
    }
}