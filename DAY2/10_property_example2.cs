// init Àü¿ë property

class Example2
{
    private int data1 = 0;
    private int data2 = 0;

    public int Data1
	{   
		get => data1;
		set => data1 = value;
    }
   

    public int Data2 
	{
		get => data2;
		set => data1 = value;
    }

    public Example2()
    {
		Data1 = 0;  
		Data2 = 0;	
    }
}

class Program
{
    public static void Main()
    {
        Example2 e1 = new Example2{ Data1 = 0, Data2 = 0 }; 

		e1.Data1 = 0;	
		e1.Data2 = 0;	
    }
}
