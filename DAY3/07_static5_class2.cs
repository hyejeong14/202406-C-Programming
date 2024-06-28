using System;

class Program 
{
	public static void Main()
	{
		// 이미 C# 표준에 Math가 존재함
		var ret = Math.Max(3.4, 2.1);
		var ret2 = Math.Sqrt(3);
		

		//또 다른 대표적인 static 클래스는 Console
		Console.WriteLine($"{ret}");
		 
		// Console c = new Console(); //error


	}
}