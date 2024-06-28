using static System.Console;

// 용어 정리
class Rect
{
    // class 의 상태를 나타내는 데이타
    // C++      : 멤버 데이타
    // C#, java : 필드(field)
    public int left;
    public int top;
    public int right;
    public int bottom;

    // 동작을 나타내는 함수
    // C++      : 멤버 함수
    // C#, Java : 메소드(method)
    public Rect(int x1, int y1, int x2, int y2)
     => (left, top, right, bottom) = (x1, y1, x2, y2);


    public int GetArea()
    {
        return (left - right) * (bottom - top);
    }
}

class Program
{
    public static void Main()
    {
        Rect rc = new Rect(10, 10, 30, 30);

        int n = rc.GetArea();

    }
}

