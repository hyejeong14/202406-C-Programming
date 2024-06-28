using static System.Console;

class Base
{
	public void Method() => WriteLine("Method");
}
class Derived : Base 
{	
}

// �ٽ� 
// 1. Derived �� Base �� ���� ��� ����� �����޴´�.
// 2. ���� Base ��ü�� �ʿ��Ҷ� "Derived ��ü" �� ����ص� �ȴ�.

delegate R MyFunc<out R>();

class Program 
{
    public static Base CreateBase()       { new Base(); }
    public static Derived CreateDerived() { new Derived(); }

	public static void Main()
	{	
		MyFunc<Base>    fbase = CreateBase;
        MyFunc<Derived> fderived = CreateDerived;

		//fbase�� ����ϴ� ���� �ᱹ Base ��ü�� ��� ���ؼ�
        Base b = fbase();
		b.Method();

		//
	}
}
