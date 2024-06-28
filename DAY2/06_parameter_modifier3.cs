using static System.Console;

class Program
{
	public static void no_modifier_parameter(int x)
	{
		int n = x;
		x = 0;
	}

	public static void out_parameter(out int x)
	{
		int n = x;	 //error. out parameter 는 초기화 되지 않은 변수를 가르킬 수 있다.
				     //담기만 하겠다는 의도
					 //초기화 되지 않은 변수를 읽을려고 시도하여 에러가 발생
		x = 0;		 //쓰기는 가능, 이 코드가 없다면 에러로 메소드가 동작하지 않음
	}

	public static void ref_parameter(ref int x)
	{
		int n = x;	
		x = 0;		
	}


	public static void Main()
	{
		int n1; 
		int n2 = 0;

		out_parameter(out n1);  // ok
		out_parameter(out n2);  // ok 초기화 되지 않아도 보낼 수 있음
		ref_parameter(ref n1);  // error 초기화 되지 않은 변수는 보낼 수 없음, 내부적으로 read & write 모두 하겠다느 의도
		ref_parameter(ref n2);  // ok
		out_parameter(out int n3); 

	}
}