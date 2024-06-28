using System;
using static System.Console;

class Train
{
	//ù��° ���� ��ü�� ����� �ð�
    private static readonly DateTime startTime;

	// �ð��� ���ڿ��� ��ȯ�ϴ� �޼ҵ�
	public  static string FirstTrainStartTime()
		=> startTime.ToLongTimeString();

	public int Color; //��ü���� �ٸ� ���� ������ ��
	public int Speed; //��ü���� �ٸ� ���� ������ ��
	 

    //public Train() { startTime = DateTime.Now; } //���� ��ü�� ���� ������ ȣ���.
											     //������ ù��° ���� ��ü�� ����� �ð��� startTime�� �ѹ��� ȣ��Ǿ�� ��
												 //static���� �����ϱ�
									
	
	
	//�Ʒ�ó�� static �����ڿ��� �ʱ�ȭ�ϸ�, ù��°�� ���� ���� ��ü�� �ð����� �ʱ�ȭ�ż� ��� ��ü�� �ش� �ð��� ������ �� ����
	static Train() { startTime = DateTime.Now;}
}

class Program 
{
	public static void Main()
	{
		Train t1 = new Train();
		WriteLine($"{Train.FirstTrainStartTime()}");

		Train t2 = new Train();
		WriteLine($"{Train.FirstTrainStartTime()}");
	}
}