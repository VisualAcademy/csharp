using System;
namespace ClassInheritance
{
    public class ParentClass : Object //ⓐ 모든 클래스는 Object 클래스에서 상속
    {
        protected void Print1() => Console.WriteLine("부모 클래스에서 정의한 내용");
    }
    public class ChildClass : ParentClass //ⓑ 콜론 기호로 부모 클래스 지정
    {
        public void Print2() =>
        base.Print1(); //ⓒ 자식에서 base 키워드로 부모 요소에 접근
    }
    class ClassInheritance : Object
    {
        static void Main()
        {
            //① 부모 클래스의 인스턴스 생성
            ParentClass p = new ParentClass();
            Console.WriteLine(p.ToString()); //ClassInheritance.ParentClass
                                             //② 자식 클래스의 인스턴스 생성
            ChildClass c = new ChildClass();
            //Print1() 메서드는 protected로 설정되어 있어 외부에서 접근 불가
            //c.Print1(); 
            c.Print2(); //자식 클래스에 직접 구현한 기능
        }
    }
}