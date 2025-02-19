using System;
using System.Linq;

class ListPatternDemo
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3 };

        // 리스트 패턴을 활용한 비교
        if (numbers is [1, 2, 3])
        {
            Console.WriteLine("리스트 패턴: 1, 2, 3 배열과 일치");
        }

        // SequenceEqual을 활용한 비교
        if (numbers.SequenceEqual(new int[] { 1, 2, 3 }))
        {
            Console.WriteLine("SequenceEqual: 1, 2, 3 배열과 일치");
        }
    }
}