using static System.Console;


interface ICamera
{
    //  private int color;  // error. 필드를 가질수 없습니다.

    //  public void SetColor(int c) => color = c; // error. 메소드 제공안됨

    void Take();  // ok

    int Weight { get; } // ok. Weight 속성을 반드시 만들라는 의미
}

class Camera : ICamera
{
    public void Take() { }
    public int Weight { get; set; }
}

// 인터페이스 : 지켜야 하는 규칙만 담을수 있습니다.
// 추상클래스 : 지켜야 하는 규칙 + 다른 멤버도 가능합니다.

abstract class AbstractCamera
{
    private int color;  // ok - 다른 멤버

    public void SetColor(int c) => color = c;  // ok - 다른 멤버

    //    void Take();  // error. 규칙은 추상클래스 문법에 맞게 다시표기

    public abstract void Take(); // ok - 반드시 지켜야 하는 규칙
}


class Program
{
    public static void Main()
    {


    }
}
