using static System.Console;

class Point
{
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;

    public Point(int a, int b) => (X, Y) = (a, b);
}

class Program
{
    public static void Main()
    {
        int n1 = 10;
        int n2 = 20;

        int n3 = n1 + n2;


        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);

        //Point p3 = p1 + p2;

        //WriteLine($"{p3.X} {p3.Y}");
    }
}
