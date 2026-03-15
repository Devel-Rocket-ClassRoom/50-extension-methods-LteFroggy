using System;

string[] strs = new string[] { 
    "토마토",
    "level",
    "기러기",
    "Level",
    "A man, a plan, a canal: Panama",
    "race a car",
    "hello",
    "가나다",
    ""
};

Console.WriteLine($"=== 회문 판별 테스트 ===");
foreach (string str in strs) {
    Console.WriteLine($"\"{str}\" -> {str.IsPalindrome()}");
}
Console.WriteLine();
Console.WriteLine();
