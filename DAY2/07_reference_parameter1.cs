using static System.Console;

class Point 
{
	public int x = 0;
	public int y = 0;
	public Point(int a, int b) => (x, y) = (a, b);
}

class Program 
{
	//레퍼런스 타입을 ref, out 없이 전달하면 객체의 상태를 변경할 수는 있지만 새롭게 생성된 객체를 담아 올 수는 없다.

	public static void NoModifier(Point pt)
	{
		pt.x = 2;
		pt.y = 2;
		pt = new Point(3,3);

	}	
	public static void Main()
	{
		Point p1 = new Point(1, 1);
		Point p2 = p1;

        // 아래 코드의 결과를 예측해 봅시다.
        NoModifier(p1);

		WriteLine($"{p1.x} {p1.y}");  // reference 타입은 원래 주소를 참조하는 형식이니까 ref modifier를 사용하지 않더라도 값이 바뀔 수 있음
		WriteLine($"{p2.x} {p2.y}"); 
	}
}