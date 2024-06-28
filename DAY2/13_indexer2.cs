class Example
{
	public int Data1
	{
		get => 0;
	}    
}
class Program
{
    public static void Main()
    {
        Example e = new Example();

        int n1 = e.Data1;
        int n2 = e[0];
        int n3 = e["A"];
        int n4 = e[0, 1];
        int n5 = e[0, "A"];
    }
}