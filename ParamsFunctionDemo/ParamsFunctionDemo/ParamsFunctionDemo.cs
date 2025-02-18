using System;

public class ParamsFunctionDemo
{
    // 가변 길이 매개 변수를 사용하여 정수 합계를 계산하는 함수
    public static int Sum(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }

    public static void Main()
    {
        // Sum 메서드를 호출하여 여러 개의 정수를 전달
        int result = Sum(1, 2, 3, 4);
        Console.WriteLine($"합계: {result}");
    }
}