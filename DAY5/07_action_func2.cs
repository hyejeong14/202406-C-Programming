
//Action : 반환 타입이 void인 경우의 delegate
//Func	 : 반환 타입이 void가 아닌 경우


//반환 타입이 있을 경우 Action 아니고 Func
delegate R Func<R>();
delegate R Func<T,R>(T arg);
delegate R Func<T1,T2,R>(T1 arg1, T2 arg2);


class Program
{
	public static int    M1() => 0;
	public static double M2(int arg) => 0;
	public static string M3(double arg) => "";
	public static object M4(int arg1, double arg2) => 0;

	public static void Main()
		{
		Func<int> f1 = M1;
		Func<int, double> f2 = M2; //리턴타입을 뒤에!
		Func<double, string> f3 = M3;
		Func<int, double, object> f4 = M4;
		}
}
