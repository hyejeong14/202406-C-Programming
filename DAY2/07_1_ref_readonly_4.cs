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
    //reference type 을 in 으로 전달할 때
    //복사본이 아닌 주소를 전달 (reference 전달)
    //가리키는 곳을 변경할 수 없음

    public static void InParameter(in Point pt)
    {
        pt.x = 2; // ok, p1을 변경 할 수는 없지만 가리키는 곳이 참조하는 곳인 x,y는 바꿀 수 있음
        pt.y = 2; // ok, 즉, 객체를 수정할 수는 있으나

        pt = new Point(3, 3); // error, 이처럼 새로운 객체를 만들어서 가져올 수는 없다
    }
    public static void Main()
    {
        Point p1 = new Point(1, 1);
        InParameter(p1);

    }
}