// required property - C#11.0

class Example3
{
    private int data1 = 0;

    // C#11.0 에서 추가된 "required"
    // => 객체 생성시 반드시 초기화 해야 한다.
    public required int Data1
    {
        get => Data1;
        set => data1 = value;
    }
}

class Program
{
    public static void Main()
    {
        Example3 e1 = new Example3 { Data1 = 0 };  // ok
        Example3 e2 = new Example3 { };		   // error
    }
}