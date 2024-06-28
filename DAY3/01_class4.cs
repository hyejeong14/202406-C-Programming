using static System.Console;

class Point3D
{
    private int x, y, z;

    // Point3D �������� �ǹ�
    // => int ��ü 3���� ������ Point3D ��ü�� ����� ��Ȱ.
    public Point3D(int a, int b, int c)
        => (x, y, z) = (a, b, c);

    // Deconstruct 
    // => Point3D �� int 3���� deconstuct �Ҷ� ���
    public void Deconstruct(out int a, out int b, out int c)
        => (a, b, c) = (x, y, z);
}

class Program
{
    public static void Main()
    {
        Point3D p = new Point3D(1, 2, 3);

        // �Ʒ� ������ ������ ���ô�.
        // => tuple �� �ƴ� Point3D Ÿ���� ��ü��
        //    tuple destruction ó�� ����ϴ� �ڵ�
        //        (int a1, int a2, int a3) = p;

        // �� �ڵ带 �����Ϸ��� �Ʒ� ó�� �����մϴ�
        p.Deconstruct(out int a1, out int a2, out int a3);



        WriteLine($"{a1}, {a2}, {a3}");
    }
}