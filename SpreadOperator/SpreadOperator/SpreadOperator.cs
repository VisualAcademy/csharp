using System;
using System.Collections.Generic;

class SpreadOperator
{
    static void Main()
    {
        // 배열 병합 예제
        int[] first = { 1, 2, 3 };
        int[] second = { 4, 5, 6 };
        int[] combined = [.. first, .. second]; // { 1, 2, 3, 4, 5, 6 }
        Console.WriteLine("배열 병합 결과: " + string.Join(", ", combined));

        // 개별 요소 추가 예제
        int[] numbers = [0, .. first, 99]; // { 0, 1, 2, 3, 99 }
        Console.WriteLine("개별 요소 추가 결과: " + string.Join(", ", numbers));

        // 리스트 병합 예제
        List<int> list1 = [1, 2, 3];
        List<int> list2 = [4, 5, 6];
        List<int> mergedList = [.. list1, .. list2]; // { 1, 2, 3, 4, 5, 6 }
        Console.WriteLine("리스트 병합 결과: " + string.Join(", ", mergedList));
    }
}
