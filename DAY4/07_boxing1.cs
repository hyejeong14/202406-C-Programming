// 116p ~ 
using static System.Console;

class CPoint 
{
	public int X{set; get;} = 0;
	public int Y{set; get;}	= 0;
	public CPoint(int a, int b) => (X, Y) = (a, b);
}

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
		CPoint cp1 = new CPoint(1, 1);
		object o = cp1;
		CPoint cp2 = (CPoint)o;

		cp1.X = 2; 
		cp1.Y = 2;

		Console.WriteLine($"{cp2.X}, {cp2.Y}");

        //---------------------------------------------
        SPoint sp1 = new SPoint(1, 1);
        object so = sp1;
        SPoint sp2 = (SPoint)so;

        sp1.X = 2;
        sp1.Y = 2;

        Console.WriteLine($"{sp2.X}, {sp2.Y}");

    }
}