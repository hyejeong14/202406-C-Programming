class Program
{
    // int 변수 2개만 swap 가능.
    public static void swap(ref int a, ref int b)
    {
        int tmp = a;
        a = b;
        b = tmp;
    }

    // double 변수 2개 swap 가능.
    // => 타입을 제외하고 구현이 int 버전과 완전히 동일합니다.
    // => 이럴때는 2개 만들지 말고 "Generic" 으로!
    // => object 받으면 안되나요 ?? => "값 타입이면 Boxing" 문제!
    public static void swap(ref double a, ref double b)
    {
        double tmp = a;
        a = b;
        b = tmp;
    }

    public static void Main()
    {
        int n1 = 10, n2 = 20;
        swap(ref n1, ref n2);

        double d1 = 1.1, d2 = 2.3;
        swap(ref d1, ref d2);
    }
}