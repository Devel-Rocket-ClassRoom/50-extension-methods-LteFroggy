using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine($"=== 컬렉션 청킹 테스트 ===");
Console.WriteLine($"[숫자를 3개씩 그룹화]");
List<int> ints = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
var chunks = ints.Chunk(3);

foreach ( IEnumerable<int> chunk in chunks ) {
    Console.WriteLine($"[");
    Console.WriteLine(string.Join(", ", chunk));
    Console.WriteLine($"]");
}
