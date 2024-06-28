using static System.Console;

class Program
{
    public static int Square(int x)
    {
        return x * x;
    }

    public static void Main()
    {
        int ret = Square(3);

        WriteLine($"{ret}");
    }
}
