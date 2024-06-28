
/*delegate void Action();
delegate void Action<T>(T arg); //delegate 오버로딩
delegate void Action<T1, T2>(T1 arg1,T2 arg2);*/


class Program 
{
	public static void M1(){}
	public static void M2(int arg){}
	public static void M3(double arg){}
	public static void M4(int arg1, double arg2){}

	public static void Main()
	{
		Action a1 = M1;
		Action<int> a2 = M2;
		Action<double> a3 = M3;
		Action<int, double> a4 = M4;
    }
}
