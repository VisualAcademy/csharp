using System;

class ReturnPreview
{
    static void Main()
    {
        Console.WriteLine("프로그램 시작");

        // 특정 조건을 검사하는 코드 (예제에서는 true로 설정)
        bool exitProgram = true;

        if (exitProgram)
        {
            Console.WriteLine("조건을 만족하여 프로그램을 종료합니다.");
            return; // 조건이 충족되면 Main 메서드를 즉시 종료
        }

        // return 문 이후의 코드는 실행되지 않음
        Console.WriteLine("조건이 충족되지 않아 프로그램이 계속 실행됩니다.");
    }
}
