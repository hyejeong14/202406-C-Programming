using static System.Console;

class Digit : IComparable
{
    public int Value { get; set; }

    public Digit(int n) => Value = n;

    // #1. ���ڷ� ��Ȯ�� Ÿ���� ǥ���߽��ϴ�
    public int CompareTo(Digit other)
    {
        return Value.CompareTo(other.Value);
    }

    // #2. IComparable �������̽��� �����ϰڴٰ� ǥ���ϰ�
    // CompareTo �� �����ϸ� ���ڸ� object �� �ϰ� �ǹǷ�
    // �Ʒ� �� ���� ĳ������ �ʿ��ϰ� �˴ϴ�.
    // "���� ����" �Ѱ� �߰��˴ϴ�.
    // => ū �������� �ƴմϴ�.
    public int CompareTo(object other)
    {
        Digit obj = (Digit)other;

        return Value.CompareTo(obj.Value);
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

