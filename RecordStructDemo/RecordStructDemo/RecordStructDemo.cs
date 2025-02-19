using System;

// 직원 정보를 나타내는 레코드 클래스
public record class EmployeeClass(string Name, int Age);

// 직원 정보를 나타내는 레코드 구조체
public record struct EmployeeStruct(string Name, int Age);

class RecordStructDemo
{
    static void Main()
    {
        // 직원 개체 생성
        var employee1 = new EmployeeClass("홍길동", 21);

        // 새로운 나이를 가진 개체 생성
        var employee2 = employee1 with { Age = 31 };

        Console.WriteLine(employee2);
    }
}
