using System;

// 1. 체이닝 vs 중첩 호출
{
    string str = "  hello world  ";

    string result1 = StringExtensions.Replace(
        StringExtensions.Upper(
        StringExtensions.Trim(str)), ' ', '_');

    string result2 = str
        .Trim()
        .Upper()
        .Replace(' ', '_');

    Console.WriteLine($"결과1: {result1}");
    Console.WriteLine($"결과2: {result2}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 접근할 수 없는 멤버
{
    SecretBox box = new SecretBox();
    box.ShowData();
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 인스턴스 메서드 우선
{
    Greeter g = new Greeter();

    g.SayHello();    
    g.SayGoodbye();  

    GreeterExtensions.SayHello(g);
    Console.WriteLine();
    Console.WriteLine();
}
