// 올바른 개체 생성 예시: required 속성(Name)을 포함하여 초기화
var person1 = new Person { Name = "Agent", Age = 30 };

//// 컴파일 오류 발생 예시: required 속성(Name)을 초기화하지 않음
//var person2 = new Person { Age = 25 };

// Person 클래스 정의
public class Person
{
    // 개체 생성 시 반드시 초기화해야 하는 필수 속성
    public required string Name { get; set; }

    // 선택적으로 초기화 가능한 일반 속성
    public int Age { get; set; }
}
