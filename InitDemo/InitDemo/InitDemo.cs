using static System.Console;

public class PersonInit
{
    public string? Name { get; init; }  // Name은 개체 초기화 시에만 설정 가능
    public int Age { get; init; }  // Age는 개체 초기화 시에만 설정 가능
    public string? Address { get; set; } // Address는 개체 생성 후에도 변경 가능
}

class InitDemo
{
    static void Main()
    {
        // 개체 초기화 시 속성 값 설정 가능
        var person = new PersonInit { Name = "홍길동", Age = 30, Address = "서울" };
        WriteLine($"이름: {person.Name}, 나이: {person.Age}, 주소: {person.Address}");

        // 개체가 생성된 후에도 Address 속성 값 변경 가능
        person.Address = "부산";
        WriteLine($"변경된 주소: {person.Address}");

        // 개체가 생성된 후에는 init 속성 값 변경 불가능 (컴파일 오류 발생)
        // person.Age = 35;  // 오류: 'init' 속성은 초기화 이후 변경할 수 없음
    }
}
