using static System.Console;

// struct 일때가 핵심 입니다.
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

    // 아래 코드의 오버헤드를 생각해보세요
    // => 값타입 객체를 "reference type" 으로 받으므로
    //    boxing 에 의한 힙 객체가 생성됩니다.
    //    성능이 좋지 않습니다.
    // => 인자로 object 가 아니라 정확한 타입으로 받는 것이 좋습니다.
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

