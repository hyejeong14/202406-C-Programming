using static System.Console;

// 프로그램에서 날짜를 많이 다루게 됩니다.

class Date
{
    // 복습할때 set 에서 유효성 검사 추가해 보세요
    public int Year { get; set; } = 0;
    public int Month { get; set; } = 0;
    public int Day { get; set; } = 0;

    // 월별 날짜수를 알아야, 다양한 날짜 관련 연산을 수행할수 있습니다.
    // => 아래 data 는 날짜 객체당 한개일 필요 없습니다.
    // => 모든 날짜 객체가 한개를 같이 사용하면 됩니다
    // => 아래 같은 데이타를 static 으로 관리하게 됩니다.
    private static int[] days = { 31, 28, 30, 31, 30, 31, 30, 31, 30, 31, 30, 31 };




    public Date(int y, int m, int d)
        => (Year, Month, Day) = (y, m, d);

    public Data AfterDays(int ds)
    {
        // 1000일 뒤 날짜 반환
        // => 잘못된 구현 입니다. 복습할때 제대로 구현해 보세요.
        return new Date(Year, Month, Day + ds);
    }

    // 아래 메소드를 "instance method"로 만들면 호출하기 위해 반드시
    // 객체가 있어야 합니다.
    // Date d = new Date(2024, 6, 26);
    // d.HowManyDays(5);
    // public int HowManyDays(int m) { return days[m - 1]; }

    // static method로 하면 
    // 객체 없이 호출 가능합니다.
    // Date.HowManyDays(5)
    public static int HowManyDays(int m) { return days[m - 1]; }

    // 아래 메소드는 "기준일"이 필요 합니다.
    // 즉, 객체가 있어야 내일도 구할수 있습니다.
    // 따라서 "객체" 를 만든후 호출하는 instance method 이어야 합니다.
    public Date Tomorrow()
    {
        Date td = new Date(Year, Month, Day);

        td.Day += 1; // 잘못된 구현. 복습시 제대로 구현해 보세요

        return td;
    }
    //IsLeapYear() 같은 메소드는 instance, static 모두 제공하는 것이 좋은 디자인
    public bool IsLeapYear()
    {
        //필드인 year를 사용해서 조사
        return false;
    }

    public static bool IsLeapYear(int y)
    {
        //인자인 y를 사용해서 조사
        return false;
    }
}

class Program
{
    public static void Main()
    {
        Date d1 = new Date(2024, 6, 24);
        Date d2 = new Date(2024, 7, 1);

        // #1. 특정일 이 지난후의 날짜 구하기 함수
        Date dest = d1.AfterDays(1000);


        // #2. 5월달이 몇일까지 있는지 알고 싶다.!
        // int ds = d1.HowManyDays(5);
        int ds = Date.HowManyDays(5);


        // #3. 내일 날짜를 알고 싶다.
        // => 아래 메소드는 static method 로 할까요 ?
        // => instance method로 할까요 ?
        Date td = d1.Tomorrow();


        // #4. 윤년인지 알고 싶다 ?
        // => 연도만 알면 된다. !!

        // #1.
        bool b1 = Date.IsLeapYear(2024);

        // #2.
        Date d3 = new Date(2024, 6, 26); // 날짜가 필요해서 이미 만들었는데
        bool b2 = d3.IsLeapYear();       // 그날짜가 윤년인지 알고 싶다
    }
}