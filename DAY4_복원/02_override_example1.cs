using static System.Console;

class Program
{
    public static void Main()
    {
        // �迭�� ũ�⸦ ���� �Ҽ� �����ϴ�.
        // => �Ʒ� �迭�� 5�� ������ �����Ҽ� �ֽ��ϴ�.
        // => ���̻� "�߰�" �Ҽ� �����ϴ�.
        int[] arr = new int[5] { 1, 2, 3, 4, 5 };

        //		arr.Add(6); // error. �迭�� �̷� �޼ҵ尡 �����ϴ�


        // ��Ҹ� ��� �߰��ϰ� �ʹٸ� �پ��� Collection �� ����ϸ� �˴ϴ�.
        List<int> list = new List<int>();   // Python �� list ���� ����
                                            // list = [];

        list.Add(1);
        list.Add(2);
        list.Add(3);

        // list �� ��Ұ� � ���� ����� ������
        WriteLine(list.Count);
    }
}