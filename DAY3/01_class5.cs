using static System.Console;

class Point3D
{
    private int x, y, z;

    public Point3D(int a, int b, int c)
        => (x, y, z) = (a, b, c);

    // Deconstruct �� �����ε� �����մϴ�.(������ ����� �ִٴ� �ǹ�)
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
        //  ��ȯ ������ �Լ����� �浹�� ���ϱ� ���ؼ�
        // int c1 = p;   �� ���� Point3D=>int�� �����ϴ� ��ȯ������ �Լ��� ȣ��ȴ�
        // ���� Deconstruct ���� �浹 ���ɼ� ������ �� �ڵ�� ������ �߻�


        WriteLine($"{a1}, {a2}, {a3}");
        WriteLine($"{b1}, {b2}");
    }
}