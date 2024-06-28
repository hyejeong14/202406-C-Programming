class Example
{
    private int data1 = 0;
	private int data2 = 0;


	//필드를 직접 만든 property(auto)가 아닌 경우는
	public int Data1 { set => data1 = value; }		//ok set-only 가능
    public int Data2 { get => data2;  }             //ok get-only도 가능
													//필드에 정의가 되어있기 때문에 set/get only 모두 가능



	public int Data3 { set; } = 0;		//error 필드 이름을 모르기 때문에 get도 없다면 값을 꺼낼 수 있는 방법이 없음 (접근 방법 X)
										//auto가 아니라면 필드 이름으로 접근하면 되지만 auto일 경우 필드 이름을 모르기 때문에 get이 없으면 접근 불가	
	public int Data4 { get; } = 0;		//ok. set이 없지만 set은 생성자에서 가능


	public Example(int a, int b)
	{
		//Data2 : get-only 필드 이름 있음
		//Data4 : get-only 필드 이름 모름
		Data2 = a;	 //error 필드이름 있으므로 아래처럼 초기화 가능
		data2 = a;  // ok
		Data4 = a;	// ok
	}
}

class Program
{
    public static void Main()
    {
        Example e1 = new Example(1, 1);
	    e.Data2 = 10;	//error get-only
		e.Data4 = 10;	//error get-only

    }
}
