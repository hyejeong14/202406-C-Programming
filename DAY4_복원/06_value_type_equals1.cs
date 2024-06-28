using System.Drawing;
using static System.Console;

struct SPoint
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public SPoint(int a, int b) => (X, Y) = (a, b);
    public static bool operator ==(SPoint a, SPoint b)
    {
        return a.X == b.X && a.Y == b.Y;
    }
    // == 제공시 != 도 같이 제공하는 것이 원칙 입니다.
    public static bool operator !=(SPoint a, SPoint b)
    {
        return !(a == b);
    }
}

class Program
{
    public static void Main()
    {
        int n1 = 10;
        int n2 = 10;

        SPoint sp1 = new SPoint(1, 2);
        SPoint sp2 = new SPoint(1, 2);

        // value type 의 equality
        // #1. == 연산자
        //  => 기본적으로 제공 안됨
        WriteLine($"{sp1 == sp2}"); //원래는 에러, 사용자가 연산자 오버로딩으로 제공가능
        WriteLine($"{n1==n2}"); //ok Int32 타입이 연산자 오버로딩으로 제공 


    }
    
}