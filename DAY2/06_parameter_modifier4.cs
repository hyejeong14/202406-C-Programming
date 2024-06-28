using static System.Console;

class Program
{
	public static void Swap(ref int x, ref int y)
	{
		int temp = x;
		x = y;
		y = temp;
	}
	public static void Main()
	{
		int x = 1;
		int y = 2;

		// Swap 을 만들어 보세요
		Swap( ref x , ref y ) ; // 보내는 쪽, 받는 쪽 모두 ref 포함


		WriteLine($"{x}, {y}"); // 2, 1 나와야 합니다.
	}
}




/*
 
 using static System.Console;

class Program
{
    // Swap : 인자의 복사본을 만들면 안됩니다.
    //        인자의 R/W가 모두 필요 합니다. 
    //        ref 로 해야 합니다.
   
    public static void Swap( ref int a, ref int b)
    {
        int temp = a;
        a = b;
		b = temp;
	}
    
// Generic 버전
public static void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
}
public static void Main()
{
    int x = 1;
    int y = 2;

    // Swap 을 만들어 보세요
    Swap(ref x, ref y);

    WriteLine($"{x}, {y}"); // 2, 1 나와야 합니다.
}
}
*/