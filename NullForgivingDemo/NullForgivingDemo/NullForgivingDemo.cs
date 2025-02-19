using System;

class NullForgivingDemo
{
    static string? Name { get; set; } // Name은 null이 될 수 있음

    static void PrintName() => 
        Console.WriteLine(Name!.ToUpper()); // Name이 null이 아님을 보장함

    static void Main()
    {
        // Name을 설정하지 않으면 기본적으로 null
        // PrintName(); // 실행하면 NullReferenceException 발생

        // 올바른 사용: Name을 먼저 설정한 후 호출
        Name = "홍길동";
        PrintName(); // 정상 출력: "홍길동" -> "홍길동".ToUpper() -> "홍길동"
    }
}
