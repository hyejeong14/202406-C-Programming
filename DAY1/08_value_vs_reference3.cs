// 1�� ����
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
        CPoint cp1; //��ü ������ ���� ����, reference(������)�� ����
        SPoint sp1; //��ü�� ���������� �����ڴ� ȣ���� ���� ����
        SPoint sp2 = new SPoint(1, 1); //��ü �����ǰ� ������ ȣ���

        cp1.x = 1; //error �߻� ��ü�� ����

        int n1 = sp1.x; //error. �ʱ�ȭ���� ���� ������ ����
        sp1.x = 1; // �ʱ�ȭ���� �ʾƵ� ����� ����

        int n2 = sp2.x; //����

        int a1; //�ʱ�ȭ �ȵ�
        int a2 = a1; // error
        a1 = n2; // ����
       

    }
}