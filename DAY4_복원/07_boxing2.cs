using static System.Console;

//class Point 
struct Point
{
	public int X{set; get;} = 0;
	public int Y{set; get;}	= 0;

	public Point(int a, int b) => (X, Y) = (a, b);
}

class Program
{
	public static bool MyReferenceEquals(object? a, 
										 object? b)
	{
		return a == b;
	}

	public static void Main()
	{
		Point p = new Point(1, 1);
		// p == p; // error

//		WriteLine($"{object.ReferenceEquals(p, p)}");
		WriteLine($"{MyReferenceEquals(p, p)}");
	}
}