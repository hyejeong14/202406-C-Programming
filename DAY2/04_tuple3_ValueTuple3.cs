using static System.Console;

class Point
{
	public int x = 0;
	public int y = 0;

	public Point(int a, int b)
	{
		x = a;
		y = b;
		// ����  2 ���� �����ϰ� �ٲٱ�
		(x,y) = (a,b); // tuple deconstruction ���



		//�Ʒ��� �ڵ�� �򰥸��� �ʰ� ����
		// -> tuple�� ������ ������ ����
		(int x, int y) t1 = (a,b);
	}


	// �Ϲ������� �޼ҵ��� ��ȯ���� ���� ��
	// ��ȯ���� tuple�� �����ϸ� 2�� �̻� ��ȯ ����
	public (int x, int y) Get() 
		// public var Get() C#������ error �߻�! Var�� Return �ڸ��� ��� �Ұ�
		//public (int,int) Get() ok

	{
		return (x, y);


	}
}


class Program 
{
	public static void Main()
	{
		Point p = new Point(1,2);
		var ret = p.Get(); //ret�� (int,int) Ÿ��
		//WriteLine($"{ret.Item1}, {ret.Item2}") ��ҷ� ������ ��
		WriteLine($"{ret.x} {ret.y}");
	}
}
