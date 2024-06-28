// 107 page ~  
using System.Runtime.Remoting;

class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int a, int b) => (X, Y) = (a, b);


    // object 가 제공하는 Equals 의 기본 구현은 객체의 동질성(==) 입니다.
    // 되도록 사용자가 override 해서 "상태의 동질성 코드"로 변경하는 것을 권장

    // 객체의 동질성을 알고 싶으면 : == 사용
    // 상태의 동질성을 알고 싶으면 : Equals() 사용하도록!!

    public override bool Equals(object? obj)
    {
        Point? other = obj as Point;

        // 혹시 null 이면 같지 않다로 처리!!
        if (other == null) return false;

        return X == other.X && Y == other.Y;
    }
}

class Program
{
    public static void Main()
    {
        // 핵심 #1. 아래 2개 완전히 외워 두세요
        // p1 == p2      : 객체의 동일성 조사
        // p1.Equals(p2) : 기본 구현은 == 사용.
        //                 하지만 대부분 "상태동일성을 조사"하도록 override

        Point p1 = new Point(1, 2);
        Point p2 = p1;


        // 핵심 2. "상태 동일성" 에 대한 최적화!

        // 1. 아래 코드의 성능을 생각해 보세요
        // => p1, p2 는 같은 객체이므로 당연히 상태도 동일합니다.
        // => 그런데, 위에서 만든 Equals 의 구현은 "모든 멤버를 하나씩 비교"
        //    하므로 성능이 나쁠수도 있습니다.
        Console.WriteLine($"{p1.Equals(p2)}");


        // object.Equals() static method 사용
        // => 구현 확인해 보세요
        Console.WriteLine($"{object.Equals(p1, p2)}");

        // 1. p1 == p2 로 동일객체라면 true
        // 2. p1, p2 가 한개라도 null 이면 false
        // 3. 그렇지 않으면 p1.Equals(p2)로 조사

    }
}