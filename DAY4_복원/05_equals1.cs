using static System.Console;
// 107 page ~  
class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int a, int b) => (X, Y) = (a, b);
}

class Program
{
	public static void Main() 
	{	
		// p1�� p1�� ���� ��ü, p2�� p1�� ����Ű�� ��ü�� ����Ŵ
		Point p1 = new Point(1,2);
		Point p2 = p1;
		Console.WriteLine()

		// p3�� p4�� �ٸ� ��ü, ������ ���� ������
		Point p3 = new Point(1,2);
		Point p4 = new Point(1,2);

		//���ϼ��� ������ ���� ��ü�� ���ϼ����� ������ ���ϼ����� �����ؾ� ��
	}
}
