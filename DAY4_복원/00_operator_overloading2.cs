using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using static System.Console;

class Point
{
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;

    public Point(int a, int b) => (X, Y) = (a, b);

    public static Point operator +(Point p1, Point p2)
    {
        Point p3 = new Point(p1.X + p2.X, p1.Y + p2.Y);

        return p3;
    }

    public void Deconstruct(out int a, out int b)
        => (a, b) = (X, Y);

    // 변환 연산자 메소드 : 이 메소드는 메소드 이름에 반환 타입이 포함됩니다.
    //                    따라서 반환 타입을 표기 하지 않는 것이 특징입니다.
    public static implicit operator int(Point pt)
        //    public static explicit operator int(Point pt)
        => pt.X;
}
class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 1);

        (int x, int y) = p1; // deconstruction
                             // p1.Deconstruct(out int x, out int y)
        int a = p1; // p1.Deconstruct(out int a) 를 호출하는 것이 아니라!
                    // Point.implicit operator int(p1)
    }
}
