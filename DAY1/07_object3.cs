//top level programming의 원리
System.Console.WriteLine("Hello, C#");

//컴파일러가 위의 코드를 아래처럼 변경함
//  => 임의 이름을 가진 클래스를 생성하고
//  => Main 메소드를 생성한 후
//  => 위 코드를 Main 메소드 안으로 옮겨 놓게 됨.


class Program
{
    public static void Main()
    {
        WriteLine("Hello, C#");
    }
}
