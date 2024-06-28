using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry");}
}
class Dog : Animal
{
    public void Cry() { WriteLine("2. Dog Cry");}
}

class Program
{
    public static void Main()
    {
		Animal a = new Animal(); 
		a.Cry();	
		
		Dog    d = new Dog();	 
		d.Cry();	
	}
}

