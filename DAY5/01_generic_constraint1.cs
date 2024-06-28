#nullable disable
using System;
using static System.Console;


class Point
{
	public int X{set;get;} = 0;
	public int Y{set;get;} = 0;
	public Point(int x, int y) => (X, Y) = (x, y);
}


class Program
{
    // Max(int, int) : int �� ���ڷ� ��밡��
    // Max(T, T)     : ��� Ÿ�� ��밡��.

    public static T Max<T>(T a,T b)
    {
        // �� �ȿ����� T Ÿ���� CompareTo�� �ִٰ� ������ �� ����
        // ���� �Ʒ� �ڵ�� ����
        // �� �ȿ����� Object�� �� �� �ִ� �ϸ� ����
        return a.CompareTo(b) < 0 ? b : a;
    }
    public static int Max(int a, int b) 
    {	
        return a.CompareTo(b) < 0 ? b : a;
    }

    public static void Main()
    {
        var ret1 = Max(3, 4);
        var ret2 = Max(3.4, 4.2);
        var ret3 = Max("A", "B");



        Point p1 = new Point(1,1);
		Point p2 = new Point(2,2);
			
    }
}
