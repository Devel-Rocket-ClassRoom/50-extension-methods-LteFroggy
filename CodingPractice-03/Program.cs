using System;
using System.Collections.Generic;

// 1. 문자열 타입 확장
{
    string str = "hello";
    Console.WriteLine($"\'hello\' 대문자로 시작 ? : {str.IsCapitalized()}");
    Console.WriteLine($"첫 글자 대문자 : {str.Capitalize()}");
    Console.WriteLine($"뒤집기 : {str.Reverse()}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 메서드 체이닝
{
    Console.WriteLine("안녕하세요 반갑습니다 좋은 하루 되세요".Take(10).AddEllipsis().AddPrefix("[메시지] ").AddSuffix(" (더보기)"));
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 컬렉션 확장
{
    string[] names = { "철수", "영희", "민수" };
    List<int> emptyList = new List<int>();

    Console.WriteLine($"names 비어있음? {names.IsEmpty()}");
    Console.WriteLine($"emptyList 비어있음? {emptyList.IsEmpty()}");
    Console.WriteLine($"names에 요소 있음? {names.HasItems()}");

    Console.WriteLine("\n이름 목록:");
    names.ForEach(name => Console.WriteLine($"  - {name}"));
}

