using static System.Console;

delegate void MyFunc(int arg);

class Program
{
    public static void SMethod(int arg) => WriteLine("SMethod");
    public void IMethod(int arg) => WriteLine("IMethod");

    public static void Main()
    {
        // #1. 앞의 예제는 "다른 클래스의 메소드를 등록하는 예제"

        // #2. 이번에는 자신의 static, instance method 이야기

        // 먼저 직접 호출
        Program.SMethod(1); // 정확한 표기법. "클래스이름.static 메소드이름"
        SMethod(2);         // 자신의 메소드에서는 "클래스이름 생략가능"

        //		IMethod(1); // error. instance method 는 객체가 필요

        Program p = new Program();
        p.IMethod(1); // ok


        // 위 코드를 잘생각해 보고 아래 ? 에 ok. error 로 채우세요
        // error 인 경우, 수정해 보세요
        MyFunc f1 = Program.SMethod; // ?
        MyFunc f2 = SMethod;         // ?
        MyFunc f3 = IMethod;         // ?

        p.InstanceMethod();
    }

    public void InstanceMethod()
    {
    }
}