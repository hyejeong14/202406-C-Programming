using static System.Console;

class Program
{
	public static void no_modifier_parameter(int x)
	{
		int n = x;
		x = 0;
	}

	public static void out_parameter(out int x)
	{
		int n = x;	 //error. out parameter �� �ʱ�ȭ ���� ���� ������ ����ų �� �ִ�.
				     //��⸸ �ϰڴٴ� �ǵ�
					 //�ʱ�ȭ ���� ���� ������ �������� �õ��Ͽ� ������ �߻�
		x = 0;		 //����� ����, �� �ڵ尡 ���ٸ� ������ �޼ҵ尡 �������� ����
	}

	public static void ref_parameter(ref int x)
	{
		int n = x;	
		x = 0;		
	}


	public static void Main()
	{
		int n1; 
		int n2 = 0;

		out_parameter(out n1);  // ok
		out_parameter(out n2);  // ok �ʱ�ȭ ���� �ʾƵ� ���� �� ����
		ref_parameter(ref n1);  // error �ʱ�ȭ ���� ���� ������ ���� �� ����, ���������� read & write ��� �ϰڴٴ� �ǵ�
		ref_parameter(ref n2);  // ok
		out_parameter(out int n3); 

	}
}