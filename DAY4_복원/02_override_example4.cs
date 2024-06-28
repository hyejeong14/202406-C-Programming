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

                    // ������ : s �� "Rect �� Circle"�� ����Ű���� Ÿ����
                    //          Shape Ÿ���̴�.

                    // �ذ�å #1. s �� Rect �� Circle Ÿ������ ĳ�����ؼ� �������

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


