using System;
using static System.Console;

class Train
{
	//첫번째 열차 객체가 출발한 시간
    private static readonly DateTime startTime;

	// 시간을 문자열로 반환하는 메소드
	public  static string FirstTrainStartTime()
		=> startTime.ToLongTimeString();

	public int Color; //객체마다 다른 값을 가져야 함
	public int Speed; //객체마다 다른 값을 가져야 함
	 

    //public Train() { startTime = DateTime.Now; } //기차 객체를 만들 때마다 호출됨.
											     //하지만 첫번째 열차 객체가 출발한 시간인 startTime은 한번만 호출되어야 함
												 //static으로 관리하기
									
	
	
	//아래처럼 static 생성자에서 초기화하면, 첫번째에 만든 기차 객체의 시간으로 초기화돼서 모든 객체가 해당 시간을 공유할 수 있음
	static Train() { startTime = DateTime.Now;}
}

class Program 
{
	public static void Main()
	{
		Train t1 = new Train();
		WriteLine($"{Train.FirstTrainStartTime()}");

		Train t2 = new Train();
		WriteLine($"{Train.FirstTrainStartTime()}");
	}
}