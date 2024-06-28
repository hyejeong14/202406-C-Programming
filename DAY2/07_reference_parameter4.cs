// 3번 복사
// 58page 그림 ~ 
using static System.Console;

class Point
{
    public int x = 0;
    public int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);
}

class Program
{
    // 규칙 4. reference 타입을 "out" 로 받으면
    // 1. 기존 객체의 속성 변경 - 안됨. 초기화되지 않은 변수도 
    //                                 받을수 있으므로 객체가 없을수 있다
    // 2. 새로운 객체 담아오기 - ok.!!
    public static void OutModifier(out Point pt)
    {
        //        pt.x = 2;   // error. 초기화 되지 않은 상태(객체가 없는)일수 있다

        pt = new Point(3, 3);   //?
    }

    public static void Main()
    {
        //      Point p1 = new Point(1, 1);
        Point p1;

        OutModifier(out p1); // out parameter 는 초기화 되지 않은
                             // 변수도 사용가능.

        WriteLine($"{p1.x} {p1.y}");
    }
}