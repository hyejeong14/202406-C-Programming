using static System.Console;


class Program
{
    public static int M1() => 1;
    public static int M2() => 2;
    public static int M3() => 3;

    public static void Main()
    {
        Func<int> del = M1;
        del += M2;
        del += M3;

        int ret1 = del();

        WriteLine($"{ret1}");

        foreach( Func<int> f in del.GetInvocationList())
        {
            int ret2 = f();

            WriteLine($"{ret2}");
        }
    }
}