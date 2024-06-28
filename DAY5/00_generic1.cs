
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
        swap(ref n1, ref n2);

        M1(1,2) //ok
        M1(1, 1.2); //error 
        M2(1, 1.2);
        M3(1, 1.2);
        M4(1); //error
        MM4<int>(1); // ok

    }

    public static void M1<T>(T a, T b) { } // ù ��° ���ڿ� �� ��° ���ڰ� ���� Ÿ���̾�� ��. (  <T> �̱� ���� )
    public static void M2<T1, T2>(T1 a, T2 b) { } // ù��°�� �ι�° ���ڰ� ���� �ٸ� Ÿ���̾ ��. 
    public static void M3<A, B>(A a, B b) { } // �ƹ����ڳ� ��밡��
    public static R M4<R, T>(T a) { return default(R)} // ���� Ÿ���� ���ڷ� �߷е����� ��ȯ Ÿ���� �߷е� �� ����. ���ڿ� ��ȯ Ÿ�� ��� �ʿ�
}
