// 75 page ~ 
using static System.Console;

// interface : Ŭ������ ���Ѿ� �ϴ� ��Ģ(�޼ҵ��̸�)�� ���� �ϴ� ���� 

// interface�� ����� ���
interface FirstGroup
{
	// �� �ȿ� �޼ҵ� ���� ����. ������ ����
	// public ���� ���� ���� �� virtual�� ǥ������ ���櫓
	void M1();
	int M2(int arg);
}

// �������̽����� ���� ��Ģ�� �������� "���" ǥ��� ���
// => Example�� FirstGroup ��Ģ�� ��Ű�ڴٴ� �ǹ�
class Example : FirstGroup
{
	// #3. Example Ŭ������ �ݵ�� FirstGroup �������̽����� ����� �޼ҵ带 �����ؾ� �Ѵ�.
	public void M1() { }
	public int M2(int arg) {return 0;}
}

class Program 
{
	public static void Main()
	{
		// interface�°�ü�� ������ �� ����
		FirstGroup g = new FirstGroup(); //error
		
		//�����μ��� ��� ����
		FirstGroup g2 = new Example(); //ok

		//��, interface�� ��ü�� ���� �� ������ ���� �����δ� ��� ������
	}
}
