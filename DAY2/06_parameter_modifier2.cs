using static System.Console;

class Program
{
    // ������ ������ ����� ��ȯ�ϴ� �޼ҵ�
    public static int AddSub1(int a, int b, ref int n) //ref �ϸ� �ʱ�ȭ�� �ʼ�
                                                       // �Լ� �ȿ��� �а� ���� �۾� ��� �ϰڴٴ� ��
    {
        n = a - b;

        return a + b;
    }

    public static int AddSub2(int a, int b, out int n) //out parameter => �������ڴٴ� �ǹ�, �ʱ�ȭ���� �ʾƵ� ����
    {
        n = a - b;

        return a + b;
    }

    public static void Main()
    {
        int ret1 = 0;

        int ret2 = AddSub(5, 3, ref ret1);

        WriteLine($"{ret1} {ret2}");
    }
}