using System;

class SwitchExpressionDemo
{
    static void Main()
    {
        object[] testValues = { 42, 3.14, "Hello", true, null };

        foreach (var obj in testValues)
        {
            string result = GetTypeDescription(obj);
            Console.WriteLine(result);
        }
    }

    static string GetTypeDescription(object obj) => obj switch
    {
        int i => $"정수 {i}",
        double d => $"실수 {d}",
        string s => $"문자열 \"{s}\"",
        bool b => $"불리언 {b}",
        null => "널 값",
        _ => "알 수 없는 형식"
    };
}
