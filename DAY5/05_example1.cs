using static System.Console;

class Program
{
    public static void Main()
    {
        int[] x = { 1, 8, 6, 4, 3 };

        // Array : 배열관련 다양한 static method 를 제공하는 클래스
        // => 배열 관련 어떤 기능이 필요하면 "Array"에서 찾으세요

        // #1. 배열에서 "3"이 있는 위치를 찾고 싶다. 값 검색
        int ret1 = Array.IndexOf(x, 3);
        WriteLine($"{ret1}"); // 4


        // #2. 배열에서 처음 나오는 "짝수"를 찾고 싶다. 조건검색
        // => FindIndex 의 2번째 인자는 "인자가 한개인 메소드" 입니다.
        int ret2 = Array.FindIndex(x, IsEven);
        WriteLine($"{ret2}"); // 1
    }

    public static bool IsEven(int n) => n % 2 == 0;
}