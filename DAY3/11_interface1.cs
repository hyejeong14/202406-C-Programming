using static System.Console;

class Program 
{
	public static void Main()
	{
		int n1 = 10;
		int n2 = 20;

		string s1 = "AAA";
		string s2 = "BBB";

		int ret1 = n1.CompareTo(n2);
		int ret2 = s1.CompareTo(s2);
		
		Foo(n1);
		Foo(s1);
	}
	
	public static void Foo(int arg)
	{
	}

}
