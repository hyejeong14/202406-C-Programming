using static System.Console;

class Point3D
{
    private int x, y, z;

    // Point3D 생성자의 의미
    // => int 객체 3개를 가지고 Point3D 객체를 만드는 역활.
    public Point3D(int a, int b, int c)
        => (x, y, z) = (a, b, c);

    // Deconstruct 
    // => Point3D 를 int 3개로 deconstuct 할때 사용
    public void Deconstruct(out int a, out int b, out int c)
        => (a, b, c) = (x, y, z);
}

class Program
{
    public static void Main()
    {
        Point3D p = new Point3D(1, 2, 3);

        // 아래 한줄을 생각해 봅시다.
        // => tuple 이 아닌 Point3D 타입의 객체를
        //    tuple destruction 처럼 사용하는 코드
        //        (int a1, int a2, int a3) = p;

        // 위 코드를 컴파일러가 아래 처럼 변경합니다
        p.Deconstruct(out int a1, out int a2, out int a3);



        WriteLine($"{a1}, {a2}, {a3}");
    }
}