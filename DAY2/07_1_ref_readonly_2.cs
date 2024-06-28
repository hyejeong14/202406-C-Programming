// 07-1_ref_readonly1.cs
using static System.Console;

// C#1.0 : ref, out 도입
// C#7.0 : in 도입 
// C#12.0: ref readonly

// #1. ref readonly 는 in 과 거의 동일합니다.
// => 단 한개의 차이(lvalue, rvalue 이야기)만 있습니다.

class Program
{
    public static void InParameter(in int x)
    {
        int n = x;
        x = 10;    // error
    }

    public static void RefReadonlyParameter(ref readonly int x)
    {
        int n = x; // ok
        x = 10;    // error
    }

    public static void Main()
    {
        int n = 0;

        InParameter(in n);
        InParameter(n);

        RefReadonlyParameter(ref n); // ok
        RefReadonlyParameter(n);     // 경고..

        WriteLine(n);
    }
}