using System;

class SpanDemo
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Span<int> span = numbers; // 배열을 Span으로 감싸기

        span[0] = 10; // 원본 배열도 변경됨
        Console.WriteLine(string.Join(", ", numbers)); // 10, 2, 3, 4, 5
    }
}
