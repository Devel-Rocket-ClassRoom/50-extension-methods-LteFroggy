using System;
using System.Linq;


static class IntExtensions
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
    public static bool IsOdd(this int number)
    {
        return number % 2 != 0;
    }

    public static string Repeat(this int number, int times) {
        return Enumerable.Repeat(number, times).ToString();
    }
}