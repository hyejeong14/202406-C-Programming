// 2������
using static System.Console;

class Program
{
    public static void Main()
    {
        int n1 = 0;
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1;
        //int[] arr3 = arr1.Clone(); // Ŭ���� ��ü�� ���纻���� ���ο� ��ü�� ����� �� ���� ����Ű�� ���°� ��.
        // ��, arr1�� arr2�� ���� ��ü, arr3�� �ٸ� ��ü�� �ȴ�
        //error! �Ʒ��� ���� �ذ��ϸ� �ȴ� ĳ�����ϱ�

        int[] arr3 = (int[])arr1.Clone();

    }
}