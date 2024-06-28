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
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);

        Point p3 = p1 + p2;  // Point.operator+(p1, p2)


        WriteLine($"{p3.X} {p3.Y}");
    }
}

// 연산자 재정의 반드시 필요한 문법일까 ?

//Point p3 = p1 + p2; // 왜?? + 하는가 ?

//Point p3 = p1.Add(p2); // 이렇게 하면 새로운 문법을 배우지 않아도 되는데 !!

// C++  : 거의 모든 연산자를 재정의 가능
// java : 연산자 재정의 문법 지원 안함
// C#   : 중요한 20여개의 연산자만 가능(+, -, *, /, ==, !=, < 등....)
// PYTHON : 대부분의 연산자 재정의 가능.
