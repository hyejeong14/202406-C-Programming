class Example
{
    private int data1 = 0;
	private int data2 = 0;


	//�ʵ带 ���� ���� property(auto)�� �ƴ� ����
	public int Data1 { set => data1 = value; }		//ok set-only ����
    public int Data2 { get => data2;  }             //ok get-only�� ����
													//�ʵ忡 ���ǰ� �Ǿ��ֱ� ������ set/get only ��� ����



	public int Data3 { set; } = 0;		//error �ʵ� �̸��� �𸣱� ������ get�� ���ٸ� ���� ���� �� �ִ� ����� ���� (���� ��� X)
										//auto�� �ƴ϶�� �ʵ� �̸����� �����ϸ� ������ auto�� ��� �ʵ� �̸��� �𸣱� ������ get�� ������ ���� �Ұ�	
	public int Data4 { get; } = 0;		//ok. set�� ������ set�� �����ڿ��� ����


	public Example(int a, int b)
	{
		//Data2 : get-only �ʵ� �̸� ����
		//Data4 : get-only �ʵ� �̸� ��
		Data2 = a;	 //error �ʵ��̸� �����Ƿ� �Ʒ�ó�� �ʱ�ȭ ����
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
