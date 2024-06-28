using static System.Console;
// 107 page ~  
class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int a, int b) => (X, Y) = (a, b);
}

class Program
{
	public static void Main() 
	{	
		// p1과 p1는 같은 객체, p2가 p1이 가리키는 객체를 가리킴
		Point p1 = new Point(1,2);
		Point p2 = p1;
		Console.WriteLine()

		// p3와 p4는 다른 객체, 하지만 같은 상태임
		Point p3 = new Point(1,2);
		Point p4 = new Point(1,2);

		//동일성을 조사할 때는 객체의 동일성인지 상태의 동일성인지 구별해야 함
	}
}
