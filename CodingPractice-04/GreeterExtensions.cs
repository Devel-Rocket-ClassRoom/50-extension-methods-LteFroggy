using System;
public static class GreeterExtensions
{
    public static void SayHello(this Greeter greeter) {
        Console.WriteLine("확장 메서드 : 반갑습니다!");
    }

    public static void SayGoodbye(this Greeter greeter) {
        Console.WriteLine("확장 메서드 : 안녕히 가세요!");
    }
}