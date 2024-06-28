using static System.Console;

delegate void Handler(Button source);

class Button
{
    public Handler Click = null; // 버튼을 누를때 호출될 함수등록

    public void UserPressButton()
    {
        Click?.Invoke(); // Click 이 null 이 아니면 호출
    }
}

class Program
{
    public static void Foo() => WriteLine("Foo");
    public static void Goo() => WriteLine("Goo");
    public static void Main()
    {
        Button btn1 = new Button();
        Button btn2 = new Button();

        btn1.Click = Foo;
        btn2.Click = Goo; // 버튼 눌렀을때 호출될 메소드 등록

        btn1.UserPressButton(); // Foo 호출
        btn2.UserPressButton(); // Goo 호출
    }
}