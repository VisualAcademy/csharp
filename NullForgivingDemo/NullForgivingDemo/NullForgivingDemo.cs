using System;

class NullForgivingDemo
{
    static string? name; // name은 null이 될 수 있음

    static void PrintName() => 
        Console.WriteLine(name!.ToUpper()); // name이 null이 아님을 보장함

    static void Main()
    {
        // name을 설정하지 않으면 기본적으로 null
        // PrintName(); // 실행하면 NullReferenceException 발생

        // 올바른 사용: name을 먼저 설정한 후 호출
        name = "Park";
        PrintName(); // 정상 출력: "Park" -> "Park".ToUpper() -> "PARK"
    }
}
