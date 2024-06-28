using static System.Console;

class Base
{
	public void Method() => WriteLine("Method");
}
class Derived : Base 
{	
}

// 핵심 
// 1. Derived 는 Base 로 부터 모든 기능을 물려받는다.
// 2. 따라서 Base 객체가 필요할때 "Derived 객체" 를 사용해도 된다.

delegate R MyFunc<out R>();

class Program 
{
    public static Base CreateBase()       { new Base(); }
    public static Derived CreateDerived() { new Derived(); }

	public static void Main()
	{	
		MyFunc<Base>    fbase = CreateBase;
        MyFunc<Derived> fderived = CreateDerived;

		//fbase를 사용하는 것은 결국 Base 객체를 얻기 위해서
        Base b = fbase();
		b.Method();

		//
	}
}
