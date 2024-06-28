// 2번 복사
// 58page 그림 ~ 
using static System.Console;

class Point
{
    public int x = 0;
    public int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);
}

class Program
{
    // 규칙 3. reference 타입을 "ref" 로 받으면
    // 1. 객체의 속성도 변경할수 있고
    // 2. 
    public static void RefModifier(ref Point pt)
    {
        pt.x = 2;
        pt.y = 2;


        // int n = 0;
        // ref int x = ref n; 일때
        // n = 10; // 10을 n 에 넣습니다.
        // x = 10; // x는 n 을 가리키는 reference 이므로
        // 10은 x을 따라간곳 n 에 넣게 됩니다.

        // pt 는 ref 입니다. 즉, main 의 p1 을 가리키는 reference
        // 아래 코드는 결국
        pt = new Point(3, 3); // pt가 가리키는 p1 = new Point(3,3)
    }

    public static void Main()
    {
        Point p1 = new Point(1, 1);

        RefModifier(ref p1);

        WriteLine($"{p1.x} {p1.y}");
    }
}