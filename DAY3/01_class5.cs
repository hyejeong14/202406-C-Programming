using static System.Console;

class Point3D
{
    private int x, y, z;

    public Point3D(int a, int b, int c)
        => (x, y, z) = (a, b, c);

    // Deconstruct 는 오버로딩 가능합니다.(여러개 만들수 있다는 의미)
    public void Deconstruct(out int a, out int b, out int c)
        => (a, b, c) = (x, y, z);

    public void Deconstruct(out int a, out int b)
        => (a, b) = (x, y);

    public void Deconstruct(out int a)
        => a = x;

}

class Program
{
    public static void Main()
    {
        Point3D p = new Point3D(1, 2, 3);

        (int a1, int a2, int a3) = p;

        (int b1, int b2) = p;

        //   int c1 = p;                 error
        //   p.Deconstruct(out in c);    ok
        //  변환 연산자 함수와의 충돌을 피하기 위해서
        // int c1 = p;   이 순간 Point3D=>int로 변경하는 변환연산자 함수가 호출된다
        // 따라서 Deconstruct 와의 충돌 가능성 때문에 위 코드는 에러가 발생


        WriteLine($"{a1}, {a2}, {a3}");
        WriteLine($"{b1}, {b2}");
    }
}