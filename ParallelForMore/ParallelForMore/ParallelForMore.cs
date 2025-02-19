Parallel.For(0, 200_000, (i) =>
{
    double result = 0;
    for (int j = 0; j < 100_000; j++) // 연산을 추가하여 CPU 부하 증가
    {
        result += Math.Sqrt(i) * Math.Pow(i, 2);
    }

    if (i % 50_000 == 0)
    {
        Console.WriteLine(
            $"i: {i}, Thread ID: {Thread.CurrentThread.ManagedThreadId}");
    }
});
