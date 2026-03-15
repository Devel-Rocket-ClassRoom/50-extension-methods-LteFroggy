using System;
using System.Collections.Generic;

List<int> intList = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
List<string> cardList = new List<string>(new string[] {"♠A", "♥K", "♦Q", "♣J"});
List<string> studentList = new List<string>(new string[] { "김철수", "이영희", "박민수", "최지연", "정우진" });

Console.WriteLine($"=== 컬렉션 셔플 테스트 ===");
Console.WriteLine();

Console.WriteLine($"[숫자 리스트 셔플]");
Console.WriteLine($"원본 : {string.Join(", ", intList)}");
intList.Shuffle();
Console.WriteLine($"셔플 : {string.Join(", ", intList)}");
Console.WriteLine();

Console.WriteLine($"[카드 덱 셔플]");
Console.WriteLine($"원본 : {string.Join(", ", cardList)}");
cardList.Shuffle();
Console.WriteLine($"셔플 : {string.Join(", ", cardList)}");
Console.WriteLine();

Console.WriteLine($"[학생 순서 무작위 배치 셔플]");
Console.WriteLine($"원본 : {string.Join(", ", studentList)}");
studentList.Shuffle();
Console.WriteLine($"셔플 : {string.Join(", ", studentList)}");
Console.WriteLine();