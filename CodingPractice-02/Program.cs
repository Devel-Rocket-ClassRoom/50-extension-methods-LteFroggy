using System;

// 1. 간단한 확장 메서드
{
    Console.WriteLine($"{"안녕하세요".First(3)}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 사용자 정의 클래스 확장
{
    Player player = new Player();
    player.Name = "용사";
    player.Level = 5;
    player.Experience = 150;

    Console.WriteLine(player.GetInfo());
    Console.WriteLine(player.CanLevelUp());
    Console.WriteLine(player.LevelUp());
    Console.WriteLine(player.GetInfo());
    Console.WriteLine();
    Console.WriteLine();
}