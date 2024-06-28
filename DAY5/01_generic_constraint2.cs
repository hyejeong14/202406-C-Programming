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

    // 방법 #1. a 를 IComparable 타입으로 캐스팅해서 사용
    // => 특징 : IComparable 인터페이스를 구현하지 않은 객체가 인자로 전달되면 캐스팅 실패, runtime error 발생함

    public static T Max<T>(T a, T b)
    {
        IComparable ia = (IComparable)a;

        return ia.CompareTo(b) < 0 ? b : a;
    }




    public static void Main()
    {
        var ret1 = Max(3, 4);
        var ret2 = Max(3.4, 4.2);
        var ret3 = Max("A", "B");



        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);

    }
}