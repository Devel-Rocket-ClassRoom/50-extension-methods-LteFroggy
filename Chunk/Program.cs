using System;
using System.Collections.Generic;

Console.WriteLine($"=== 컬렉션 청킹 테스트 ===");
Console.WriteLine($"[숫자를 3개씩 그룹화]");
List<int> ints = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
var chunks = ints.Chunk(3);

foreach (IEnumerable<int> chunk in chunks ) {
    Console.Write($"[");
    Console.Write(string.Join(", ", chunk));
    Console.WriteLine($"]");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"[학생들을 2명씩 팀 구성]");
List<string> students = new List<string>(new string[] { "김철수", "이영희", "박민수", "최지연", "정우진" });
var teams = students.Chunk(2);
var teamNumber = 1;
foreach (IEnumerable<string> chunk in teams) {
    Console.Write($"팀 {teamNumber++} : ");
    Console.WriteLine(string.Join(", ", chunk));
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"[페이지별로 5개씩 나누기]");
var pages = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 });
var pageChunks = pages.Chunk(5);
var pageNumber = 1;
foreach (IEnumerable<int> chunk in pageChunks) {
    Console.Write($"페이지 {pageNumber} : ");
    Console.WriteLine(string.Join(", ", chunk));
}
Console.WriteLine();
Console.WriteLine();
