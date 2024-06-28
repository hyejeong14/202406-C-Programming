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
                {
                    // s.Draw();// error. 

                    // 문제점 : s 는 "Rect 나 Circle"을 가리키지만 타입이
                    //          Shape 타입이다.

                    // 해결책 #1. s 를 Rect 나 Circle 타입으로 캐스팅해서 사용하자

                    if (s is Rect r)
                    {
                        r.Draw();
                    }
                    else if (s is Circle c)
                    {
                        c.Draw();
                    }
                }
            }
        }
    }
}


