// 75 page ~ 
using static System.Console;

// interface : 클래스가 지켜야 하는 규칙(메소드이름)을 정의 하는 문법 

// interface를 만드는 방법
interface FirstGroup
{
	// 이 안에 메소드 선언만 포함. 구현부 없음
	// public 같은 접근 제어 및 virtual도 표기하지 안흥ㅁ
	void M1();
	int M2(int arg);
}

// 인터페이스에서 만든 규칙을 따르려면 "상속" 표기법 사용
// => Example은 FirstGroup 규칙을 지키겠다는 의미
class Example : FirstGroup
{
	// #3. Example 클래스는 반드시 FirstGroup 인터페이스에서 약속한 메소드를 구현해야 한다.
	public void M1() { }
	public int M2(int arg) {return 0;}
}

class Program 
{
	public static void Main()
	{
		// interface는객체를 생성할 수 없음
		FirstGroup g = new FirstGroup(); //error
		
		//참조로서는 사용 가능
		FirstGroup g2 = new Example(); //ok

		//즉, interface는 객체를 만들 수 없지만 참조 변수로는 사용 가능함
	}
}
