class Example
{
    // 필드는 없지만 항상 0을 반환하는 속성
    public int Data1 { get => 0; }

    // 아래 main 이 에러나오지 않게 이 부분 만들어 보세요.
    // => 모든 0 반환해 보세요.
    public int this[int idx]
    {
        get => 0;
    }
    public int this[string idx]
    {
        get => 0;
    }
    public int this[int idx1, int idx2]
    {
        get => 0;
    }
    public int this[int idx1, string idx2]
    {
        get => 0;
    }
}

class Program
{
    public static void Main()
    {
        //      Example e = new Example();
        Example e = new();  // 위코드를 이렇게 해도 됩니다.
                            // 좌변을 보고 우변의 타입이 추론 됩니다.

        int n1 = e.Data1; // 0

        int n2 = e[0];
        int n3 = e["A"];
        int n4 = e[0, 1];
        int n5 = e[0, "A"];
    }
}