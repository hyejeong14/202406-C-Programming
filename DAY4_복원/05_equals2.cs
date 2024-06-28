// 107 page ~  
using System.Runtime.Remoting;

class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int a, int b) => (X, Y) = (a, b);


    // object �� �����ϴ� Equals �� �⺻ ������ ��ü�� ������(==) �Դϴ�.
    // �ǵ��� ����ڰ� override �ؼ� "������ ������ �ڵ�"�� �����ϴ� ���� ����

    // ��ü�� �������� �˰� ������ : == ���
    // ������ �������� �˰� ������ : Equals() ����ϵ���!!

    public override bool Equals(object? obj)
    {
        Point? other = obj as Point;

        // Ȥ�� null �̸� ���� �ʴٷ� ó��!!
        if (other == null) return false;

        return X == other.X && Y == other.Y;
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = p1;
        Point p3 = new Point(1, 2);
        Point p4 = new Point(1, 2);

        // Reference Type �� ���. 
        // ��� #1. == ������ ���
        // => ��ü�� ���ϼ� ���� ( ���� ��ü�ΰ�)
        Console.WriteLine($"{p1 == p2}, {p3 == p4}"); // True, False


        // ��� #2. object �� ���� ��� �޴� Equals()�����Լ� ���
        // => object �ȿ� �ִ� �⺻ ������  "==" �� ��
        //    ��, �⺻ ������ "��ü�� ���ϼ�" ����

        Console.WriteLine($"{p1.Equals(p2)}, {p3.Equals(p4)}");
    }
}