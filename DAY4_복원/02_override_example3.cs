using static System.Console;

class Shape
{
}

class Rect : Shape
{
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
        List<Shape> list = new List<Shape>();

        while (true)
        {
            int cmd = int.Parse(Console.ReadLine() ?? "0");

            if (cmd == 1) list.Add(new Rect());
            else if (cmd == 2) list.Add(new Circle());
            else if (cmd == 9)
            {
                foreach (var s in list)
                    s.Draw();       // A error.            }
                                    // list 가 List<Shape>  타입이므로
                                    // s 자체는 Shape 타입입니다.
                                    // Shape 참조로 Rect 를 가리킬수 있지만
                                    // Rect 고유 멤버는 접근할수 없습니다.
                                    // 그래서 에러
            }
        }
    }
// 위 코드는 어디서??  왜?? 에러일까요 ?
// => A 에서 에러
// 해결책을 생각해 보세요.. 
// => 다음소스에서.. 이부분을 이해 하는 것이 객체 지향 디자인의 핵심원리


