using System;
using System.Linq;

// 1. 확장 메서드란?
{
    string str = "Hello, World!";
    Console.WriteLine($"{StringHelper.CountWords(str)}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 확장 메서드 방식
{
    string str = "Hello, World!";
    Console.WriteLine($"단어 개수 : {str.CountWords()}");
    Console.WriteLine();
    Console.WriteLine();   
}

// 3. 숫자 타입 확장
{
    Console.WriteLine($"10은 짝수인가 ? : {10.IsEven()}");
    Console.WriteLine($"7은 홀수인가 ? : {7.IsOdd()}");
    Console.WriteLine($"3을 5번 반복 : {3.Repeat(5)}");
    Console.WriteLine();
    Console.WriteLine();
}