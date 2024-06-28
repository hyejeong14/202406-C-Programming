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
		WriteLine($"{MyReferenceEquals(p, p)}"); // 같은 객체를 보내지만 boxing 현상 때문에 각각 복사본이 생성되어 다른 객체를 가리키게 된다.
		// 근데 == 연산자는 객체가 동일한지 조사하는 연산자이기 때문에 false가 반환되는 것! 
		// value타입을 참조타입처럼 쓸때 (여기서는 int타입을 object타입으로 바꿈) boxing현상이 일어남!
		// 그렇기 때문에 value 타입은 myreferenceEquals 결과가 항상 false로 나오게 됨
	}
}