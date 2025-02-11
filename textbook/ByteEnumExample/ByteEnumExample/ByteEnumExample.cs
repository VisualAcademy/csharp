using System;

enum Status : byte 
{
    Inactive = 0,
    Active = 1,
    Pending = 2
}

class ByteEnumExample
{
    static void Main()
    {
        Status currentStatus = Status.Active;
        Console.WriteLine($"현재 상태: {currentStatus}({(byte)currentStatus})");

        currentStatus = Status.Pending;
        Console.WriteLine($"현재 상태: {currentStatus}({(byte)currentStatus})");
    }
}
