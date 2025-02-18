using System;

namespace NestedStructures
{
    // 주소 정보를 나타내는 구조체
    struct Address
    {
        public string Street; // 거리명
        public string City;   // 도시명
        public string ZipCode;// 우편번호
    }

    // 학생 정보를 나타내는 구조체
    struct Student
    {
        public string Name;           // 학생 이름
        public Address StudentAddress; // 주소 정보 (Address 구조체를 사용)
    }

    class Program
    {
        static void Main()
        {
            // 학생 구조체 변수를 초기화. 주소 정보도 함께 초기화한다.
            Student student1 = new Student();
            student1.Name = "철수";
            student1.StudentAddress = new Address
            { Street = "123번길", City = "서울", ZipCode = "12345" };

            // 학생 정보를 출력
            Console.WriteLine("이름: " + student1.Name);
            Console.WriteLine("주소:");
            Console.WriteLine("  거리: " + student1.StudentAddress.Street);
            Console.WriteLine("  도시: " + student1.StudentAddress.City);
            Console.WriteLine("  우편번호: " + student1.StudentAddress.ZipCode);
        }
    }
}
