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

    // 생성자 : 객체를 생성할때 자동으로 호출되는 함스
    // => 멤버데이타(필드)를 초기화 하기 위한 용도로 사용
    public Rect(int x1, int y1, int x2, int y2)
    {
        left = x1;
        top = y1;
        right = x2;
        bottom = y2;
    }


    public int GetArea()
    {
        return (left - right) * (bottom - top);
    }
}

class Program
{
    public static void Main()
    {
        // 생성자 덕분에, 객체 초기화가 아래 처럼 간단해 졌습니다
        Rect rc = new Rect(10, 10, 30, 30);

        int n = rc.GetArea();

    }
}

