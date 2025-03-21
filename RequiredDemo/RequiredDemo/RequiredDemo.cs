public class PersonRequired
{
    public required string Name { get; set; } // 필수 속성
    public required int Age { get; set; } // 필수 속성
    public string? Address { get; set; } // 선택적 속성
}

class RequiredDemo
{
    static void Main()
    {
        // 필수 속성을 포함한 올바른 개체 초기화
        var person = new PersonRequired { Name = "홍길동", Age = 21 };
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

        // 필수 속성이 누락되면 컴파일 오류가 발생함
        // var invalidPerson = new PersonRequired { Name = "백두산" };
    }
}
