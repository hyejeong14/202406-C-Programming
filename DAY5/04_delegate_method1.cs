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
        // �ٽ� : delegate �� method �� ����ϴ� ���
        // static method   :
        // instance method : 
	}
}
