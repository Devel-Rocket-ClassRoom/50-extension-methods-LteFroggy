using System;

static class StringExtension {
    public static bool IsPalindrome(this string str) {

        // 공백 혹은 null이면 false 반환
        if (string.IsNullOrEmpty(str)) { return false; }

        // 전부 lowercase로
        str = str.ToLower();

        // 문자, 숫자만 비교대상으로
        string newStr = "";
        foreach (char c in str) {
            if (char.IsLetterOrDigit(c)) {
                newStr += c;
            }
        }
        str = newStr;

        // 공백 전부 제거
        newStr = "";
        foreach (char c in str) {
            if (!char.IsWhiteSpace(c)) {
                newStr += c;
            }
        }
        str = newStr;

        // 판별 
        int left = 0;
        int right = str.Length - 1;

        while (left < right) {
            if (str[left] != str[right]) { return false; }
            left++;
            right--;
        }
        
        return true;
    }
}