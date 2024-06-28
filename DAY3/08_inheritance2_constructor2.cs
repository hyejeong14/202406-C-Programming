using static System.Console;

class Base
{
    //  public Base() { WriteLine("Base()"); }

    // 핵심 : Base 클래스에 인자가 없는 생성자가 없습니다.
    // => 아래 Derived 에서 에러를 모두 찾으세요.
    public Base(int a) { WriteLine("Base(int)"); }
}
class Derived : Base
{
    public Derived()            //컴파일러가 변경한 코드
                                //Derived() : base()
    {
        WriteLine("Derived()");
    }
    public Derived(int a)           //Derived(int) : base()
    {
        WriteLine("Derived(int)");
    }
}

class Program
{
    public static void Main()
    {
        Derived d1 = new Derived();
        //      Derived d2 = new Derived(3);
    }
}