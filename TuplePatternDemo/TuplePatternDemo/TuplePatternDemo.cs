using System;

class TuplePatternDemo
{
    static void Main()
    {
        (int, int) point = (0, 5);
        string position = point switch
        {
            (0, 0) => "원점",
            (0, _) => "Y축 위",
            (_, 0) => "X축 위",
            _ => "일반 위치"
        };

        Console.WriteLine($"({point.Item1}, {point.Item2}) -> {position}");
    }
}
