using static System.Console;



class Button
{
    //delegate를 class 안에 만들어도 됨.
    //Button 안에서만 사용하겠다는 의도
    public delegate void Handler(Button source);
    //public Handler Click = null; // 버튼을 누를때 호출될 함수등록
    //Handler delegate를 직접 사용하지 말고 앞에 event를 붙이면 =은 안되고 += 또는 -=만 됨!
    //안전하게 사용 가능~
    public event Handler? Click = null;
    public void UserPressButton()
    {
        Click?.Invoke(this); // Click 이 null 이 아니면 호출
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

        btn1.Click += Foo;
        btn1.Click += Goo;
        //    btn1.Click += Hoo;
        //  만약에 += 가 아니라 =로 실수하게 된다면 추가가 아니라 리셋이됨!
        btn1.Click += Hoo; // 따라서 = 기호는 쓰지 못하게 하는 것이 좋겠따/~
        btn1.UserPressButton();
    }
}