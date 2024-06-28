using static System.Console;

// Predicate(������) : bool �� ��ȯ�ϴ� �޼ҵ�
//                    �˻����ǵ��� ���� �Լ��� ���鶧 ���
//                    ��κ��� ���� "predicate" ��� ���
delegate bool Predicate(int n);

class Program
{
    public static bool IsEven(int n) => n % 2 == 0;

    public static void Main()
    {
        int[] x = { 1, 8, 6, 4, 3 };

        int ret1 = Array.FindIndex(x, IsEven);
        int ret2 = MyFindIndex(x, IsEven);

        WriteLine($"{ret1} {ret2}"); // 1, 1
    }

    // Array.FindIndex �� ���� ����� ���ô�.
    public static int MyFindIndex(int[] arr, Predicate match)
    {
        int sz = arr.Length;

        for (int i = 0; i < sz; i++)
        {
            if (match(arr[i]))
                return i;
        }

        return -1;
    }
}