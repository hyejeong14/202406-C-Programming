using static System.Console;


// event 의 원리!!

class Button
{
    public delegate void Handler(Button source);

    public event Handler? Click = null;

    // delegate를 그냥사용하지 않고 event 붙이면 컴파일러가 아래 처럼변경

    // 1. Click 은 private 으로 놓고
    private Handler? Click = null;

    // 2. 아래 2개의 메소드 추가
    public void add_Click(Handler handler)
    {
        Click += handler;
    }

    public void remove_Click(Handler handler)
    {
        Click -= handler;
    }


    public void UserPressButton()
    {
        Click?.Invoke(this);
    }
}

class Program
{
    public static void Foo(Button source) => WriteLine("Foo");
    public static void Goo(Button source) => WriteLine("Goo");
    public static void Hoo(Button source) => WriteLine("Hoo");

    public static void Main()
    {
        Button btn1 = new Button();


        btn1.Click += Goo; // btn1.add_Click(Goo)
        btn1.Click -= Goo; // btn1.remove_Click(Goo)


        btn1.UserPressButton();
    }
}