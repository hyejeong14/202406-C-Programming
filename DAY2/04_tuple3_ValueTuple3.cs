using static System.Console;

class Point
{
	public int x = 0;
	public int y = 0;

	public Point(int a, int b)
	{
		x = a;
		y = b;
		// 위의  2 줄을 간결하게 바꾸기
		(x,y) = (a,b); // tuple deconstruction 기법



		//아래의 코드와 헷갈리지 않게 주의
		// -> tuple의 생성은 변수가 있음
		(int x, int y) t1 = (a,b);
	}


	// 일반적으로 메소드의 반환값으 ㄴ한 개
	// 반환값을 tuple로 설정하면 2개 이상 반환 가능
	public (int x, int y) Get() 
		// public var Get() C#에서는 error 발생! Var를 Return 자리에 사용 불가
		//public (int,int) Get() ok

	{
		return (x, y);


	}
}


class Program 
{
	public static void Main()
	{
		Point p = new Point(1,2);
		var ret = p.Get(); //ret은 (int,int) 타입
		//WriteLine($"{ret.Item1}, {ret.Item2}") 요소로 접근할 때
		WriteLine($"{ret.x} {ret.y}");
	}
}
