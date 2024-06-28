using static System.Console;

//모든 타입은 object(System.Object)로 부터 파생(상속)된다.

class Car  //class  Car : System.Object
{	
}

class Program
{
	public static void Main()
	{
		Car c = new Car();
		WriteLine(c.ToString);
	}
}
