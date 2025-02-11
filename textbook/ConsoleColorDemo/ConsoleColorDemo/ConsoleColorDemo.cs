using System;

class ConsoleColorDemo
{
    static void Main()
    {
        // 전경색 변경
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Blue");
        Console.ResetColor();

        // 배경색 변경
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Red");
        Console.ResetColor();
    }
}
