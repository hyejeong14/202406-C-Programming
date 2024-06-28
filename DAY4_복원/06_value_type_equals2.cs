using System.Drawing;
using static System.Console;

struct SPoint
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public SPoint(int a, int b) => (X, Y) = (a, b);

}

class Program
{
    public static void Main()
    {
        int n1 = 10;
        int n2 = 10;

        SPoint sp1 = new SPoint(1, 2);
        SPoint sp2 = new SPoint(1, 2);

        // Equals() 가상 메소드 사용
        //  => Object의 기본 구현은 == 사용
        //  => ValueType 클래스에서 Equals를 Override 하여 2개 객체이 메모리를 통째로 비교함(C언어의 memcpy같이)
        // * ValueType은 스택에 존재
        // 모든 Value Type은 상속을 받음
        // 일부 멤버만 비교하도록 하려면 override 하면 됨.
     
        WriteLine($"{sp1.Equals(sp2)}");


    }

}