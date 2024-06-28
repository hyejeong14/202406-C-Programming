using System.Drawing;
using static System.Console;

struct SPoint
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public SPoint(int a, int b) => (X, Y) = (a, b);

}

class Program
{
    public static void Main()
    {
        int n1 = 10;
        int n2 = 10;

        SPoint sp1 = new SPoint(1, 2);
        SPoint sp2 = sp1;

        // sp1, sp2는 ValueType이므로 같은 객체가 아님
        // =>서로 다른 객체인데 상태는 동일함
        //아래 두줄은 모두 False, => Boxing 현상 때문임
        WriteLine($"{object.ReferenceEquals(sp1, sp2)}");
        WriteLine($"{object.ReferenceEquals(sp1, sp1)}");

        WriteLine($"{sp1.Equals(sp2)}");

        //결론 : Value Type 에는 아래 2개 사용시 에러는 발생하지 않지만 사용 권장 X, Boxingㅐ문에 잘못된 결과 초래 예상

    }

}