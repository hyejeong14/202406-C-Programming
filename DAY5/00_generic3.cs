class Program
{
    // Generic Method
    public static void swap<T>(ref T a, ref T b)
    {
        T tmp = a;
        a = b;
        b = tmp;
    }

    public static void Main()
    {
        int n1 = 10, n2 = 20;
        double d1 = 1.1, d2 = 2.3;

        swap<int>(ref n1, ref n2);      // �̼��� "�޼ҵ�Ʋ"���� T=int��
                                        // swap(ref int, ref int) �޼ҵ����
        swap<double>(ref d1, ref d2);   // swap(ref double, ref double) �޼ҵ����

        // generic �޼ҵ�� �Լ� ���ڷ� Ÿ�� �߷��� �����մϴ�.
        // "swap<int>" ���� Ÿ���� �����ص� �ǰ�, �����ص� �˴ϴ�
        swap(ref n1, ref n2); <-

    }
}