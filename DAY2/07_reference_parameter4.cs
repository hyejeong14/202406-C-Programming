// 3�� ����
// 58page �׸� ~ 
using static System.Console;

class Point
{
    public int x = 0;
    public int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);
}

class Program
{
    // ��Ģ 4. reference Ÿ���� "out" �� ������
    // 1. ���� ��ü�� �Ӽ� ���� - �ȵ�. �ʱ�ȭ���� ���� ������ 
    //                                 ������ �����Ƿ� ��ü�� ������ �ִ�
    // 2. ���ο� ��ü ��ƿ��� - ok.!!
    public static void OutModifier(out Point pt)
    {
        //        pt.x = 2;   // error. �ʱ�ȭ ���� ���� ����(��ü�� ����)�ϼ� �ִ�

        pt = new Point(3, 3);   //?
    }

    public static void Main()
    {
        //      Point p1 = new Point(1, 1);
        Point p1;

        OutModifier(out p1); // out parameter �� �ʱ�ȭ ���� ����
                             // ������ ��밡��.

        WriteLine($"{p1.x} {p1.y}");
    }
}