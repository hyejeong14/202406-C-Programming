
class Program
{
    public static void Main()
    {
        //이미 C#에 날짜 클래스가 있음
        // => 정확히는 Struct가 있음

        DateTime dt = new DateTime(2024, 6, 26);

        //1000일 뒤 날짜는?
        DateTime dest = dt.AddDays(1000);

        Console.WriteLine(dest.ToString() );

        DateTime.IsLeapYear(2024);  //static method
                                    //객체가 없음
                                    //인자로 연도를 받아야 함
    }
}