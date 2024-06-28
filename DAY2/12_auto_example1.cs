class Person
{	
	public string Name;
	public string Address;

	public Person(string name, string address)
	{
		Name = name;
		Address = address;
	}	
}

class Program 
{
	public static void Main()
	{
		Person p = new();

		p.name    = "kim";
		p.address = "seoul";
	}
}