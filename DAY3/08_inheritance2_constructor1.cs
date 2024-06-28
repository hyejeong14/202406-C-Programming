using static System.Console;

class Base
{
    public Base() { WriteLine("Base()"); }
    public Base(int a) { WriteLine("Base(int)"); }
}
class Derived : Base
{
    // 사용자가 만든 코드         // 컴파일러가 변경한 코드( 대부분의 언어가 유사)
    public Derived()            // public Derived() : base()  <== "base 키워드"
    {
        WriteLine("Derived()");
    }
    public Derived(int a)       // public Derived(int a) : base() 
    {
        WriteLine("Derived(int)");
    }
}

class Program
{
    public static void Main()
    {
        //      Derived d1 = new Derived();
        Derived d2 = new Derived(3);
    }
}