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

                    using static System.Console;


// 해결책 #2. 모든 파생클래스(도형)의 공통된 특징은 반드시 기반 클래스에도 있어야 한다.
//           (문법적인 규칙이 아닌 디자인의 규칙)
//          그래야 Shape 참조로 해당 기능을 사용할수 있다.

                    // 핵심 1. 파생 클래스가 "override" 하게되는 것은 "virtual" 로 만들어야 한다.
                    //         (디자인 규칙)

                    // 핵심 2. 파생 클래스가 "override" 하지 않은 것은 "non-virtual" 로!

class Shape
    {
        private int color;

        // 아래 2개 메소드는 "virtual" 로 할까요 ? "non-virtual"로 할까요 ?
        // => 파생 클래스가 다시 만들 필요 없습니다.
        // => non-virtual
        public void SetColor(int c) { color = c; }
        public int GetColor() { return color; }


        // 모든 도형은 면적을 구할수 있습니다.
        // => virtual ? non-virtual
        // => 파생 클래스가 다시 만들게 되므로 virtual
        // => non-virtual 로 해도 다시 만들수 있지만 s.GetArea()가 항상
        //    Shape 메소드 호출 합니다. 잘못된 동작
        public virtual int GetArea() { return 0; }


        public virtual void Draw() { WriteLine("Draw Shape"); }
    }



    class Rect : Shape
    {
        public override void Draw() { WriteLine("Draw Rect"); }
    }
    class Circle : Shape
    {
        public override void Draw() { WriteLine("Draw Circle"); }
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
                        // Shape 에 Draw가 있으므로 아래처럼 사용가능
                        s.Draw();
                    }
                }
            }
        }
    }




}
            }
        }
    }
}


