// C#의 모든 코드는 반드시 클래스로 작성되어야 한다.
// EntryPoint 도 클래스로 작성 되어야 한다.

//Entry Point 규칙
// => Main이라는 이름으 static 메소드를 가진 클래스를 만들어야 함

//C# 9.0 이전 까지는 반드시 아래처럼 작성해야 했음
using static System.Console;

class Program
{
    public static void Main()
    {
        WriteLine("Hello, C#");
    }
}
