using System;

class ReadOnlySpanDemo
{
    static void Main()
    {
        string text = "Hello, Span!";

        // 문자열을 ReadOnlySpan으로 감싸기
        ReadOnlySpan<char> readOnlySpan = text.AsSpan();

        Console.WriteLine(readOnlySpan[0]); // H

        // readOnlySpan[0] = 'X'; // 컴파일 에러 (읽기 전용)
    }
}
