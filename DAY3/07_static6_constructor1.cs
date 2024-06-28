using static System.Console;

// static constructor
// => 다른 객체지향 언어에는 없는 C#만의 특징

class Train
{
	private int speed = 0;

	// 생성자 : 객체 당 한번 씩 호출
	public Train() { WriteLine("Train()"); speed = 50;  }

	//static 생성자 : 객체 생성에 상관 없이 최초 1회만 호출
	//접근지정자(public)을 표기하지 않음
	static Train() { WriteLine("static Train()"); }
}

class Program 
{
	public static void Main()
	{
		Train t1 = new Train();
		Train t2 = new Train();
		Train t3 = new Train();
	}
}