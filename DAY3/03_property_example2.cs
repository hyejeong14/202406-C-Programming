// init ���� property

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
        init => data2 = value;  // ��ü ������ �ʱ�ȭ�� ������ �Ӽ�
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
        // #1. ������Ƽ�� ������ ��ü ������
        // {} �� ����ؼ� �ʱ�ȭ �����մϴ�
        //      Example2 e1 = new Example2(0, 0); // ���ڰ� 2���� �����ڷ� �ʱ�ȭ
        Example2 e1 = new Example2 { Data1 = 0, Data2 = 0 };

        // #2. set vs init
        e1.Data1 = 0;   // ok. set
        e1.Data2 = 0;	// error. init property.
    }
}

