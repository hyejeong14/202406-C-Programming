// init 전용 property

class Example2
{
    private int data1 = 0;
    private int data2 = 0;

    public int Data1
    {
        get => data1;
        set => data1 = value;
    }

    public int Data2
    {
        get => data2;
        //		set => data2 = value;
        init => data2 = value;  // 객체 생성시 초기화만 가능한 속성
    }

    public Example2()
    {
        Data1 = 0;
        Data2 = 0;
    }
}

class Program
{
    public static void Main()
    {
        // #1. 프라퍼티가 있으면 객체 생성시
        // {} 를 사용해서 초기화 가능합니다
        //      Example2 e1 = new Example2(0, 0); // 인자가 2개인 생성자로 초기화
        Example2 e1 = new Example2 { Data1 = 0, Data2 = 0 };

        // #2. set vs init
        e1.Data1 = 0;   // ok. set
        e1.Data2 = 0;	// error. init property.
    }
}

