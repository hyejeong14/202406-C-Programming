using static System.Console;

// �ٽ� : ����� ���� Ŭ������ ũ�� �� �Լ��� �����ϰ� �ʹٸ�
//	=> �ǵ����̸� C# ����� �ڵ� ��Ģ�� ������
//	=> ICompareable �������̽� ����

class Label : IComparable
{
	private string title;
	
	public Label(string s) => title = s;

    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }
}

class Program 
{
	public static void Main()
	{
		Label d1 = new Label("GOOD");
		Label d2 = new Label("BAD");


		int ret = d1.CompareTo(d2);

		
	}

	public static void Foo(IComparable ic)
	{
	}
}

