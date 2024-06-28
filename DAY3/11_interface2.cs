using static System.Console;

class Label 
{
	private string title;
	
	public Label(string s) => title = s;
}

class Program 
{
	public static void Main()
	{
		Label d1 = new Label("GOOD");
		Label d2 = new Label("BAD");

		int ret = d1.CompareTo(d2);




		
	}
	public static void Foo(IComparable ic)
	{
	}
}

