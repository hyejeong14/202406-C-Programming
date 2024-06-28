#nullable disable
using System;
using static System.Console;


class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int x, int y) => (X, Y) = (x, y);
}


class Program
{

    // 방법 #2. generic constraint 문법 사용
    // => 아래 코드는 "조건을 만족하는 타입"만 받겠다는 의미이다.
    // => 조건 : IComparable 인터페이스를 구현한 타입

    // => IComparable 인터페이스를 구현하지 않은 타입의 객체를 전달하려고 하면
    //    컴파일 에러
    //    Max(Point객체, Point객체) 는 컴파일 에러
    public static T Max<T>(T a, T b) where T : IComparable
    {
        return a.CompareTo(b) < 0 ? b : a;
    }



    public static void Main()
    {
        var ret1 = Max(3, 4);
        var ret2 = Max(3.4, 4.2);
        var ret3 = Max("A", "B");

        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);

        var ret4 = Max(p1, p2);
    }
}