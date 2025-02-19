using System;

// 구독자 정보를 나타내는 레코드
record Subscriber(string Title, int Duration, bool IsAvailable);

class RecordDemo
{
    static void Main()
    {
        // 구독자 개체 생성
        var subscriber = new Subscriber("Visual", 3, true);

        // 새로운 제목을 가진 개체 생성
        var vip = subscriber with { Title = "VIP" };

        Console.WriteLine(vip);

        // 개체 값 분해
        var (title, duration, isAvailable) = subscriber;

        Console.WriteLine($"{title} - {duration} - {isAvailable}");
    }
}
