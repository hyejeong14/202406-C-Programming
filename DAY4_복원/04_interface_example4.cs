using static System.Console;

interface IA { void M1();}
interface IB { void M1();}

class Example : IA, IB 
{
	public void M1() { WriteLine("M1"); }
}

class Program 
{
	public static void Main()
	{
		Example e = new Example();
		e.M1();	
	}
}