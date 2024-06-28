using static System.Console;

class Digit : IComparable
{
    public int Value { get; set; }

    public Digit(int n) => Value = n;

    // #1. 인자로 정확한 타입을 표시했습니다
    public int CompareTo(Digit other)
    {
        return Value.CompareTo(other.Value);
    }

    // #2. IComparable 인터페이스를 구현하겠다고 표기하고
    // CompareTo 를 구현하면 인자를 object 로 하게 되므로
    // 아래 와 같이 캐스팅이 필요하게 됩니다.
    // "참조 변수" 한개 추가됩니다.
    // => 큰 오버헤드는 아닙니다.
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

