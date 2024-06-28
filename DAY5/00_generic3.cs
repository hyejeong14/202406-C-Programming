class Program
{
    // Generic Method
    public static void swap<T>(ref T a, ref T b)
    {
        T tmp = a;
        a = b;
        b = tmp;
    }

    public static void Main()
    {
        int n1 = 10, n2 = 20;
        double d1 = 1.1, d2 = 2.3;

        swap<int>(ref n1, ref n2);      // 이순간 "메소드틀"에서 T=int인
                                        // swap(ref int, ref int) 메소드생성
        swap<double>(ref d1, ref d2);   // swap(ref double, ref double) 메소드생성

        // generic 메소드는 함수 인자로 타입 추론이 가능합니다.
        // "swap<int>" 같이 타입을 전달해도 되고, 생략해도 됩니다
        swap(ref n1, ref n2); <-

    }
}