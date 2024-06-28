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

		// Swap �� ����� ������
		Swap( ref x , ref y ) ; // ������ ��, �޴� �� ��� ref ����


		WriteLine($"{x}, {y}"); // 2, 1 ���;� �մϴ�.
	}
}




/*
 
 using static System.Console;

class Program
{
    // Swap : ������ ���纻�� ����� �ȵ˴ϴ�.
    //        ������ R/W�� ��� �ʿ� �մϴ�. 
    //        ref �� �ؾ� �մϴ�.
   
    public static void Swap( ref int a, ref int b)
    {
        int temp = a;
        a = b;
		b = temp;
	}
    
// Generic ����
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

    // Swap �� ����� ������
    Swap(ref x, ref y);

    WriteLine($"{x}, {y}"); // 2, 1 ���;� �մϴ�.
}
}
*/