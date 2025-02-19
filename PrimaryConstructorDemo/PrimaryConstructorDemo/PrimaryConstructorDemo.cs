using System;

class Employee(string name, int age) // 기본 생성자 사용
{
    private readonly string _name = name;
    private readonly int _age = age;

    public void Display() => 
        Console.WriteLine($"이름: {_name}, 나이: {_age}");
}

class PrimaryConstructorDemo
{
    static void Main()
    {
        Employee employee = new("홍길동", 21);
        employee.Display();
    }
}
