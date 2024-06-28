// 27page ~ 
using static System.Console;

class CPoint
{
	private int x;
	private int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	private int x;
	private int y;
	public SPoint(int a, int b) { x = a; y = b;}	
}
class Program 
{
	public static void Main()

	{
		//아래 코드는 객체를 생성하는 방법은 완전히 동일함
		//	=> but, 메모리의 구조는 다르다

		//배열은 value type? or reference type? 
		//c# : reference type, 배열 자체는 힙에 존재함
		//arr는 힙에 있는 데이터를 가르키는 레퍼런스 (주소)

		//swift : value type 으로 설계됨. 배열자체가 stack에 있음
		// 배열의 할당/해지가 c#보다 빠름
		int[] arr = { 1, 2, 3, 4, 5 };

		//날짜와 시간은 value? or reference?
		//struct니까 stack
		DateTime tm = new DateTime(2024,1, 1);

	}
}

//C# 은
//struct 타입으로 만든 것을 value type이라고 하고, 객체 생성시 stack에 위치하게됨.
//