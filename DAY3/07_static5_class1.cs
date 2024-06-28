using static System.Console;

// ���а��� �Լ��� ���̺귯���� �����ϰ� �ʹ�.
// => C���� "����� �ƴ� �Ϲ� �Լ�" ��� ���� ����� ������
// => C#�� ��� ���� Ŭ�����θ� ����� �ִ�.
// => "top level programming" �� �ᱹ Main �Լ������� �̵��ϴ� ��

// #1. �Ʒ� ó�� �Ϲ�(����� �ƴ�) �Լ��� ����� �����ϴ�.
/*
int Max(int a, int b)
{
	return a < b ? b : a;
}

int Square(int x)
{
	return x * x;
}
*/

// #2. Ŭ������ ������ �մϴ�.
// static class : ��� ����� static�� Ŭ������ ��ü�� ������ �� ���� �ϱ� ���� ���
//                Math�� static���� ���ص� ������, �����ϰ� �ϱ� ���ؼ��� static class�� �����ϴ� ���� ����
static class Math
{
    public static int Max(int a, int b)
    {
        return a < b ? b : a;
    }

    int Square(int x)
    {
        return x * x;
    }
}

class Program
{
    public static void Main()
    {
        int n = Math.Square(2)
    }
}