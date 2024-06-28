using static System.Console;

// struct �϶��� �ٽ� �Դϴ�.
struct Digit : IComparable
{
    public int Value { get; set; }

    public Digit(int n) => Value = n;

    /*
    public int CompareTo(Digit other)
    {
        return Value.CompareTo(other.Value);
    }
    */

    // �Ʒ� �ڵ��� ������带 �����غ�����
    // => ��Ÿ�� ��ü�� "reference type" ���� �����Ƿ�
    //    boxing �� ���� �� ��ü�� �����˴ϴ�.
    //    ������ ���� �ʽ��ϴ�.
    // => ���ڷ� object �� �ƴ϶� ��Ȯ�� Ÿ������ �޴� ���� �����ϴ�.
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

