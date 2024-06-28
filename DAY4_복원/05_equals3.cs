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
        // �ٽ� #1. �Ʒ� 2�� ������ �ܿ� �μ���
        // p1 == p2      : ��ü�� ���ϼ� ����
        // p1.Equals(p2) : �⺻ ������ == ���.
        //                 ������ ��κ� "���µ��ϼ��� ����"�ϵ��� override

        Point p1 = new Point(1, 2);
        Point p2 = p1;


        // �ٽ� 2. "���� ���ϼ�" �� ���� ����ȭ!

        // 1. �Ʒ� �ڵ��� ������ ������ ������
        // => p1, p2 �� ���� ��ü�̹Ƿ� �翬�� ���µ� �����մϴ�.
        // => �׷���, ������ ���� Equals �� ������ "��� ����� �ϳ��� ��"
        //    �ϹǷ� ������ ���ܼ��� �ֽ��ϴ�.
        Console.WriteLine($"{p1.Equals(p2)}");


        // object.Equals() static method ���
        // => ���� Ȯ���� ������
        Console.WriteLine($"{object.Equals(p1, p2)}");

        // 1. p1 == p2 �� ���ϰ�ü��� true
        // 2. p1, p2 �� �Ѱ��� null �̸� false
        // 3. �׷��� ������ p1.Equals(p2)�� ����

    }
}