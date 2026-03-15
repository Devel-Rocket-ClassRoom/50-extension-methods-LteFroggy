using System;
public static class SecretBoxExtensions
{
    public static void ShowData(this SecretBox box) {
        Console.WriteLine($"공개 데이터: {box.PublicData}");
    }
}
