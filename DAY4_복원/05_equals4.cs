// 107 page ~  
using System.Runtime.Remoting;

class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int a, int b) => (X, Y) = (a, b);

    // == 는 기본적으로를 "객체의 동질성(동일객체인가)" 입니다
    // 그런데, 연산자 재정의를 통해서 "상태의 동질성"으로 변경할수 있습니다.
    public static bool operator ==(Point a, Point b)
    {
        return a.X == b.X && a.Y == b.Y;
    }
    // == 제공시 != 도 같이 제공하는 것이 원칙 입니다.
    public static bool operator !=(Point a, Point b)
    {
        return !(a == b);
    }
}

class Program
{
    //public static bool MyReferenceEquals(Point a, Point b)
    public static bool MyReferenceEquals(object a, object b)
        => a == b;

    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = new Point(1, 2);

        Console.WriteLine($"{p1 == p2}");  // true

        // == 가 operator overloading 되어 있어도
        // 객체의 동질성을 조사하고 싶다.
        // => p1, p2 가 Point 타입이므로 Point 안의 operator==사용
        // => p1, p2 를 object 로 캐스팅하면 기본 버전의 == 사용
        Console.WriteLine($"{(object)p1 == (object)p2}");  // false

        Console.WriteLine($"{MyReferenceEquals(p1, p2)}");
        Console.WriteLine($"{object.ReferenceEquals(p1, p2)}");
        // => 이 메소드 구현이 MyReferenceEquals와 동일





        /*

        string s1 = new string("ABC");
        string s2 = new string("ABC");

        // s1, s2 는 다른 객체
        Console.WriteLine($"{s1 == s2}");  // True.
                    // 즉, string 은 "operator==" 메소드 재정의
    */
    }
}


