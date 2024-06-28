using static System.Console;

class Program
{
    public static void M1(int a, int b, int c)
	{
	 	WriteLine($"{a}, {b}, {c}");
	} 
    public static void Main()
    {
        M1(10, 20, 30); // 10, 20, 30
    }

    // 주의 사항
//    public static void M2(int a, int b = 0, int c = 0) { }  
//    public static void M3(int a = 0, int b, int c = 0) { }  
//    public static void M4(int a, int b = 0, int c) { }      
}