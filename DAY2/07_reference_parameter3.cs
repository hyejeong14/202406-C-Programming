// 2�� ����
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
    // ��Ģ 3. reference Ÿ���� "ref" �� ������
    // 1. ��ü�� �Ӽ��� �����Ҽ� �ְ�
    // 2. 
    public static void RefModifier(ref Point pt)
    {
        pt.x = 2;
        pt.y = 2;


        // int n = 0;
        // ref int x = ref n; �϶�
        // n = 10; // 10�� n �� �ֽ��ϴ�.
        // x = 10; // x�� n �� ����Ű�� reference �̹Ƿ�
        // 10�� x�� ���󰣰� n �� �ְ� �˴ϴ�.

        // pt �� ref �Դϴ�. ��, main �� p1 �� ����Ű�� reference
        // �Ʒ� �ڵ�� �ᱹ
        pt = new Point(3, 3); // pt�� ����Ű�� p1 = new Point(3,3)
    }

    public static void Main()
    {
        Point p1 = new Point(1, 1);

        RefModifier(ref p1);

        WriteLine($"{p1.x} {p1.y}");
    }
}