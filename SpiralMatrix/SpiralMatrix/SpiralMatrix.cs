using System;

class SpiralMatrix
{
    static void Main()
    {
        const int N = 5;

        // 나선형으로 값을 채울 2차원 배열
        int[,] arr = new int[N, N];

        // 현재 채워야 할 숫자
        int num = 1;

        // 위쪽, 아래쪽, 왼쪽, 오른쪽 경계
        int top = 0;
        int bottom = N - 1;
        int left = 0;
        int right = N - 1;

        // 나선형으로 배열 채우기
        while (top <= bottom && left <= right) // 나선형으로 덮지 않은 영역이 남아 있는 동안 반복
        {
            // → 오른쪽으로 채우기
            for (int i = left; i <= right; i++)
            {
                arr[top, i] = num++;
            }
            top++;

            // ↓ 아래쪽으로 채우기
            for (int i = top; i <= bottom; i++)
            {
                arr[i, right] = num++;
            }
            right--;

            // ← 왼쪽으로 채우기
            for (int i = right; i >= left; i--)
            {
                arr[bottom, i] = num++;
            }
            bottom--;

            // ↑ 위쪽으로 채우기
            for (int i = bottom; i >= top; i--)
            {
                arr[i, left] = num++;
            }
            left++;
        }

        // 결과 출력
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("{0,3}", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}