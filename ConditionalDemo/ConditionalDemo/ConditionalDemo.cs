#define RELEASE //②-1 전처리기 지시문으로 RELEASE 기호 정의
using System;
using System.Diagnostics;
public class ConditionalDemo
{
    static void Main()
    {
        DebugMethod();
        ReleaseMethod();
    }
    [Conditional("DEBUG")] //① DEBUG 기호(심벌)를 가지는 경우 실행
    static void DebugMethod() => Console.WriteLine("디버그 환경에서만 표시");
    //②-2 RELEASE 기호가 있는 경우 실행
    [Conditional("RELEASE")]
    static void ReleaseMethod()
        => Console.WriteLine("릴리스 환경에서만 표시");
}
