class Example1
{
    private int data1 = 0;
    private int data2 = 0;
    private int data3 = 0;
    private int data4 = 0;
    private int data5 = 0;




    // property 를 만들어 봅시다.

    // #1. 기본 코드.
    public int Data1
    {
        get { return data1; }
        set { data1 = value; }
    }

    // #2. expression bodied
    public int Data2
    {
        get => data2;
        //set => data2 = value;
        init => data1 = value; // 객체 생성시 초기화만 가능한 속성
    }

    // #3. get only
    // var ret = e.Data3; // ok
    // e.Data3 = 10;      // error
    public int Data3
    {
        get => data3;
    }

    // #4. set only
    // var ret = e.Data4; // error
    // e.Data
    public int Data4
    {
        set => data4 = value;
    }

    // #5.private set
    // => 외부에서는 set은 안됨
    // => 내부에서는 가능
    // get only : setter가 없다는 것. 내부에서는 필드이름으로만 접근해야 한다.
    // private set : setter가 있지만, 내부에서만 사용 가능
    public int Data5
    {
        get => data5;
        private set => data5 = value;
    }

    public Example1()
    {
        data5 = 0; //필드를 직접 접근하는 코드
        Data5 = 0; // 속성을 통해서 접근하는 코드
                   // 유효성 검사 로직이 있다면 적용됨.
                   // private 이지만 메소드이므로 접근 가능
    }

   
}

class Program
{
    public static void Main()
    {
        //Example1 e1 = new Example();

        // #1. property가 있으면 객체 생성시 {}를 사용해서 초기화 가능
        Exampple2 e1 = new Exampple2 { Data1 = 0, Data2 = 0 };

        // #2.set vs init
        e1.Data1 = 0; //ok set
        e1.Data2 = 0; //error. inint property
    }
}


