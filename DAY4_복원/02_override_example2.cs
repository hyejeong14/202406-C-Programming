using static System.Console;

// 파워 포인트 같은 프로그램을 객체지향 언어로 만드는 것을 생각해 봅시다.

// 1. 모든 도형을 타입으로 설계하면 편리합니다
// 2. 모든 도형의 공통의 기반 클래스가 있다면
//    모든 도형 객체를 하나의 컬렉션에 모두 보관 가능합니다.

class Shape
{
}

class Rect : Shape
{
    // int x, y, w, h, 생성자등은 생략, 있다고 가정하고 가상함수에 예제에집중

    public void Draw() { WriteLine("Draw Rect"); }
}
class Circle : Shape
{
    public void Draw() { WriteLine("Draw Circle"); }
}

class Program
{
    public static void Main()
    {
        //		List<Rect> list = new List<Rect>(); // Rect 객체만 보관가능
        //      List<object> list = new List<object>(); // 모든 객체만 보관가능

        List<Shape> list = new List<Shape>(); // 모든 도형을 보관가능
    }
}