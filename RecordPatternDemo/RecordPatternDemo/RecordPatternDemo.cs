using System;

public record Person(string Name, int Age);

class RecordPatternDemo
{
    static void Main()
    {
        Person person = new("홍길동", 21);

        string description = person switch
        {
            { Name: "홍길동", Age: 21 } => "홍길동은(는) 21세입니다.",
            { Age: > 18 } => "성인입니다.",
            _ => "미성년자입니다."
        };

        Console.WriteLine(description);
    }
}