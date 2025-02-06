using static System.Console;

class UnsignedRightShiftDemo
{
    static void Main()
    {
        int x = -4;
        WriteLine($"{x,11}, {Convert.ToString(x, 2).PadLeft(32, '0'),32}");

        int y = x >> 1;
        WriteLine($"{y,11}, {Convert.ToString(y, 2).PadLeft(32, '0'),32}");

        int z = x >>> 1;
        WriteLine($"{z,11}, {Convert.ToString(z, 2).PadLeft(32, '0'),32}");
    }
}
