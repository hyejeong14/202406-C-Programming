// 1����
using static System.Console;

class Digit : IComparable
{
    public int Value { get; set; }

    public Digit(int n) => Value = n;

    // #1. ���ڷ� ��Ȯ�� Ÿ���� ǥ���߽��ϴ�
    public int CompareTo(object other)
    {
        Digit obj = {Digit
                )=

        return Value.CompareTo(other.Value);
    }
}

class Program
{
    public static void Main()
    {
        Digit d1 = new Digit(3);
        Digit d2 = new Digit(4);

        int ret = d1.CompareTo(d2);

    }
}

