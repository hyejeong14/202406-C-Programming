using static System.Console;

class Program
{
    public static int MyComparer(int a, int b)
    {
        //		return a.CompareTo(b); // ���� ����
        return b.CompareTo(a); // ���� ����
    }

    public static void Main()
    {
        int[] x = { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };

        // �ٽ� : �迭�� ��� ��Ҹ� �����ϱ�.
        //		Array.Sort(x);	// ���� ���� 1,2,3,4,5,6,7,8,9,10

        // ������ ������ �����Ϸ��� 2��° ���ڷ� 2�� �޼ҵ� ������ �˴ϴ�.
        // ���� "C# Array.Sort" ���� MS ����Ʈ 
        Array.Sort(x, MyComparer);



        foreach (var e in x)
            Write($"{e}, ");
    }

}
