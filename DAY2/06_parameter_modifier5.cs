using static System.Console;

class Program
{
    public static void Main()
    {
        //		string s = "10";
        string s = "ABC";

        //      int n = int.Parse(s); // s 가 int로 변경 불가능하면
        // runtime error (예외) 발생. 

        // C# 메소드의 특징
        // "Try" 로 시작하는 메소드는 성공/실패 여부를 반환하고
        // 연산의 결과는 out parameter로 알려 줍니다.
        bool b = int.TryParse(s, out int n);
        // 실패시 false 반환하고
        // n 을 디폴트 값으로 채워 줍니다.

        Console.WriteLine($"{b} {n}");
    }
}