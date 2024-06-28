using System.Runtime.CompilerServices;
using static System.Console;

class Program
{
    public static void MAin()
    {
        string s = "aa";
        int n = 10;



        WriteLine($"{CMC.SizeOf<int>()}");
        CMC.PrintHeapObjectAddr(s);
        unsafe
        {
            CMC.PrintAddr(&n);
        }
        //WriteLine($"{CMC.PrintAddr(&n)}");

    }
}