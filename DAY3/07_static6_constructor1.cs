using static System.Console;

// static constructor
// => �ٸ� ��ü���� ���� ���� C#���� Ư¡

class Train
{
	private int speed = 0;

	// ������ : ��ü �� �ѹ� �� ȣ��
	public Train() { WriteLine("Train()"); speed = 50;  }

	//static ������ : ��ü ������ ��� ���� ���� 1ȸ�� ȣ��
	//����������(public)�� ǥ������ ����
	static Train() { WriteLine("static Train()"); }
}

class Program 
{
	public static void Main()
	{
		Train t1 = new Train();
		Train t2 = new Train();
		Train t3 = new Train();
	}
}