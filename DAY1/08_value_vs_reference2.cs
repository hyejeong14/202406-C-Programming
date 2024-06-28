using static System.Console;

class CPoint
{
    public int x;
    public int y;
    public CPoint(int a, int b) { x = a; y = b; }
}
struct SPoint
{
    public int x;
    public int y;
    public SPoint(int a, int b) { x = a; y = b; }
}
class Program
{
    public static void Main()
    {
        // �Ʒ� cp1, cp2 �� sp1, sp2�� �޸� �׸��� �����غ�����
        // 28 page ���� �׸��� �Ϻ��� �����ؾ� �մϴ�.
        CPoint cp1 = new CPoint(1, 1);
        CPoint cp2 = cp1; // cp1�� ���� ��ü�� �ּҸ� cp2�� �����Ѱ�

        cp1.x = 2;

        WriteLine($"{cp1.x}, {cp2.x}");
        // 2


        SPoint sp1 = new SPoint(1, 1);
        SPoint sp2 = sp1;   // sp1�� �ٸ� sp2 ��ü�� �����ϴµ�
                            // sp1 �� ����� ������ ���� �Ѱ�


        sp1.x = 2;
        WriteLine($"{sp1.x}, {sp2.x}");

    }
}
