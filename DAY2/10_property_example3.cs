// required property - C#11.0

class Example3
{
    private int data1 = 0;
	
    public int Data1 
	{
		get => Data1;
		set => data1 = value;
    }
}

class Program
{
    public static void Main()
    {
        Example3 e1 = new Example3{Data1 = 0}; 
		Example3 e2 = new Example3{};		   
    }
}
