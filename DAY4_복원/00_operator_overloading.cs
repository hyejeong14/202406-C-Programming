using static System.Console;

class Point
{
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;

    public Point(int a, int b) => (X, Y) = (a, b);
}

class Program
{
    public static void Main()
    {
        int n1 = 10;
        int n2 = 20;

        // #1. primitive type 은 더하기 위해서 "+"를 사용합니다.
        // primitive type : 언어 자체가 제공하는 타입(int, double)
        int n3 = n1 + n2;

        // user define type : 사용자가 만든 타입(class, struct 문법)
        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);

        // 핵심 : 사용자 정의 타입의 객체도 "+" 할수 있을까요 ?
        // operator overloading : +, - 같은 연산자를 사용자 정의 타입에
        //                        대해서도 사용할수 있게 하는 것
        // 원리 : "+" 사용시 약속된 메소드를 호출하는 것. 

        Point p3 = p1 + p2; // 파이썬 : p1.__add__(p2)
                            // C#    : Point.operator+(p1, p2)
                            // C++   : p1.operator+(p2)

        // 구현은 2번소스에서


        WriteLine($"{p3.X} {p3.Y}");
    }
}


