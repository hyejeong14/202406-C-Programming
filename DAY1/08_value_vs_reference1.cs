// 27page ~ 
using static System.Console;

class CPoint
{
	private int x;
	private int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	private int x;
	private int y;
	public SPoint(int a, int b) { x = a; y = b;}	
}
class Program 
{
	public static void Main()

	{
		//�Ʒ� �ڵ�� ��ü�� �����ϴ� ����� ������ ������
		//	=> but, �޸��� ������ �ٸ���

		//�迭�� value type? or reference type? 
		//c# : reference type, �迭 ��ü�� ���� ������
		//arr�� ���� �ִ� �����͸� ����Ű�� ���۷��� (�ּ�)

		//swift : value type ���� �����. �迭��ü�� stack�� ����
		// �迭�� �Ҵ�/������ c#���� ����
		int[] arr = { 1, 2, 3, 4, 5 };

		//��¥�� �ð��� value? or reference?
		//struct�ϱ� stack
		DateTime tm = new DateTime(2024,1, 1);

	}
}

//C# ��
//struct Ÿ������ ���� ���� value type�̶�� �ϰ�, ��ü ������ stack�� ��ġ�ϰԵ�.
//