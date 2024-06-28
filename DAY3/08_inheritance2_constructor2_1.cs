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
    //Base : 기반 클래스
    //Derived : 파생 클래스
    //핵심 : 기반 클래스에 " 디폴트 생성자(인자없는 생성자)"가 없다면 파생 클래스에서 기반 클래스 생성자를 명시적으로 호출해야 함
    public Derived()  : base(0)           //컴파일러가 변경한 코드
                                //Derived() : base()
    {
        WriteLine("Derived()");
    }
    public Derived(int a) : base(a)        //Derived(int) : base()
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