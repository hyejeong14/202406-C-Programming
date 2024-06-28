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
        Point p1 = new Point(1, 2);
        Point p2 = p1;
        Point p3 = new Point(1, 2);
        Point p4 = new Point(1, 2);

        // Reference Type 인 경우. 
        // 방법 #1. == 연산자 사용
        // => 객체의 동일성 조사 ( 동일 객체인가)
        Console.WriteLine($"{p1 == p2}, {p3 == p4}"); // True, False


        // 방법 #2. object 로 부터 상속 받는 Equals()가상함수 사용
        // => object 안에 있는 기본 구현은  "==" 로 비교
        //    즉, 기본 구현은 "객체의 동일성" 조사

        Console.WriteLine($"{p1.Equals(p2)}, {p3.Equals(p4)}");
    }
}