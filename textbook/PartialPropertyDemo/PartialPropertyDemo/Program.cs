using System;

// 첫 번째 파일: 선언 부분
public partial class EmployeePartial
{
    public partial string FullName { get; set; }
}

// 두 번째 파일: 구현 부분
public partial class EmployeePartial
{
    private string _fullName = ""; // 초기값을 빈 문자열로 설정
    public partial string FullName
    {
        get => _fullName;
        set => _fullName = value.ToUpper(); // 값을 대문자로 변환
    }
}

class PartialPropertyDemo
{
    static void Main()
    {
        EmployeePartial employee = new EmployeePartial();
        employee.FullName = "john doe";
        Console.WriteLine(employee.FullName); // JOHN DOE
    }
}
