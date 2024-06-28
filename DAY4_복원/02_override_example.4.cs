using static System.Console;


// OCP 용어
// 기능 추가에는 열려있고(Open, 클래스/모듈를 나중에 추가하더라도)
// 코드 수정에는 닫혀있어야(Close, 기존 코드는 수정되지 않게)
// 하라는 원칙(Principle)

// Open Close Principle (개방 폐쇄의 법칙 )

// 객체지향 설계의 5대 원칙 
// => SOLID ( SRP, OCP, LSP, ISP, DIP 의 약자)


//  다형성(가상함수기반 코드) 는 OCP를 만족하는 아주 좋은 코드 입니다.

class Shape
{
    private int color;

    public void SetColor(int c) { color = c; }
    public int GetColor() { return color; }

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
                    // 아래 한줄을 생각해 봅시다
                    // => "s.Draw()" 라는 한줄의 표현식이 
                    //    상황에 따라(s가 가리키는 객체의 종류에 따라)
                    //    다르게 동작합니다.
                    // => "다형성(Polymorphism)" 이라고 합니다.
                    s.Draw();

                    // 객체지향 언어의 3대 특징 : 캡슐화, 상속, 다형성

                    // 위 한줄의 코드는 새로운 도형(Triangle등)이 추가되어도
                    // 수정될 필요 없습니다.
                }
            }
        }
    }
}


