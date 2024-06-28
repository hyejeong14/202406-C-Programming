using static System.Console;

// 객체지향 프로그램의 개념
// => 프로그램에서 필요한 타입을 먼저 설계 하자!!

// 사각형이 필요 하면 "Rect" 라는 타입을 먼저 설계해라
class Rect
{
    public int left;
    public int top;
    public int right;
    public int bottom;

    public int GetArea()
    {
        return (left - right) * (bottom - top);
    }
}
class Program
{
    public static void Main()
    {
        // 위처럼 Rect 라는 타입을 라이브러리 설계자가 만들어 주면
        // 일반 개발자는 아래 처럼 사용하면 됩니다.
        Rect rc = new Rect();

        rc.left = 10;
        rc.top = 10;
        rc.right = 30;
        rc.bottom = 30;

        int n = rc.GetArea();

    }
}

