using static System.Console;

class Program
{
    public static void Main()
    {
        int[] array = { 1, 3, 6, 4, 5 };

     
        
        int idx = Array.FindIndex(array, n => n % 2 == 0);


    
        Func<int, int> square = n => n * n;

        int ret = square(3);

        WriteLine($"{ret}");

    }
}