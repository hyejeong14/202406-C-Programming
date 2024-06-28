
using static System.Console;

class Program
{
    public static void Main()
    {
        int n1 = 10;
        int n2 = 20;

        string s1 = "AAA";
        string s2 = "BBB";

        // ��ü�� ũ�� �� ���

        // ��� #1. �� ������ (<, > ���)
        bool b1 = n1 < n2; // ok. ��ġ Ÿ���� ����
                           //      bool b2 = s1 < s2; // error. string �� ��������

        // ��� #2. CompareTo �޼ҵ�

        int ret1 = n1.CompareTo(n2); // n1 �� ũ�� ���, ������ ����, ������ 0
        int ret2 = s1.CompareTo(s2); // string �� ����.

        // �ٽ� : C#�� �����ϴ� Ÿ�Կ���  ũ�� �񱳰� ������ ��� Ÿ����
        //        "CompareTo" �޼ҵ� �ֽ��ϴ�.

        IComparable c = s1;
    }



    //public static void Foo(object arg) //int ���Ը� �ްڴٴ� �ǹ�
    //public static void Foo(object arg) //��� ��ü�� �ްڴ�
    public static void Foo(IComparable arg) //CompareTo�� �ִ� �͸� �ްڴٴ� �ǹ�
    {
        //�� �ȿ��� arg�� ���ؼ� Compare To�� ����ϰ� �˴ϴ�.
        //CompareTo�� �ִ� ��ü�� ���ڷ� �޾ƾ� �Ѵٸ�
    }

}