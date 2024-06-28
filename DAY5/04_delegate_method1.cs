using static System.Console;

class Test
{
    public static void SMethod(int arg) 	
		=> WriteLine("Test.SMethod");

    public void IMethod(int arg)
		=> WriteLine("Test_Object.IMethod");
}

delegate void MyFunc(int arg);

class Program
{
    public static void Main()
    {
        // 핵심 : delegate 에 method 를 등록하는 방법
        // static method   :
        // instance method : 
	}
}
