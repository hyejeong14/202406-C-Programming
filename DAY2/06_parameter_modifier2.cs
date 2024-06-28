using static System.Console;

class Program
{
    // 덧셈과 뺄셈의 결과를 반환하는 메소드
    public static int AddSub1(int a, int b, ref int n) //ref 하면 초기화가 필수
                                                       // 함수 안에서 읽고 쓰는 작업 모두 하겠다는 뜻
    {
        n = a - b;

        return a + b;
    }

    public static int AddSub2(int a, int b, out int n) //out parameter => 꺼내오겠다는 의미, 초기화되지 않아도 가능
    {
        n = a - b;

        return a + b;
    }

    public static void Main()
    {
        int ret1 = 0;

        int ret2 = AddSub(5, 3, ref ret1);

        WriteLine($"{ret1} {ret2}");
    }
}