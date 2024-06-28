// C# 6.0 이전 : ref, out 은 메소드 인자에서만 사용가능했습니다.
// C# 7.0 이후 : ref 를 지역변수를 만들때도 사용 가능해 졌습니다.
//              즉, value type 에 대한 reference 도 만들수 있게 되었습니다.

class Program
{
    public static void Main()
    {
        int n = 10;

        // F(ref int x) / F(ref n)
        ref int x = ref n;

        n = 20; // 자신의 메모리에 20 넣기
        x = 30; // x는 reference 이므로
                // 따라간 곳(대상체)에 넣게 됩니다.
                // C언어(*x = 30)

        Console.WriteLine($"{x}");

    }
}