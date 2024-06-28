// 54 page ~ 
// "C����� call by value, call by reference" �� ���� C# ���

using static System.Console;

class Program
{
    // �Ʒ� �ڵ�� ������ ���纻�� �����˴ϴ�. 55p ���� �׸� ����
    // "call by value"
    // Inc1 ���� x�� �����ص� main �� n �� ����ȵ�
    public static void Inc1(int x) { ++x; }
    public static void Inc2(ref int x) { ++x; }

    public static void Main()
    {
        int n = 0;

        Inc1(n); // �ǵ� : n �� 1�����ϰ� �ʹ�. - 55p ���ʱ׸�
                 // �Լ��� ���� ������ �Լ��� ����� ���������� ����鼭
                 // �ʱ�ȭ �ϴ� ����, ��, �Ʒ� �ڵ�� ����
                 // "int x = n" 
        WriteLine(n); // 0 

        Inc2(ref n);  // ref parameter �� ���ڸ� �����Ҷ��� �ݵ�� (ref -> reference ��� ��, �����̳� ���� �� ref�� �� �Ѵ� �ٿ��� ��)
                      // ref �� ǥ���ؾ� �մϴ�.
                      // => ���� �ƴ� reference �� ������ �޶�°�
                      // => �ᱹ �޸� �ּ� ����
        WriteLine(n); // 1 
    }
}