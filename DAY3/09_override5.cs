using static System.Console;

class Base
{
	public void M1() {}
	public void M2() {}
	public virtual void M3() { WriteLine("Base M3");}
	public virtual void M4() { WriteLine("Base M4");}	
}
class Derived : Base 
{
	
}

class Program 
{
	public static void Main()
	{
		Base b = new Derived();
		b.M3(); 
		b.M4();
	}
}