class Program
{
    public static void M1(int a1) { }
    public static void M2(int a1, int a2) { }
    public static void M3(int[] ar) { }
	public static void M4(params int[] ar) { } //�������� �޼ҵ�, M3�� �����ϰ� �迭�� �䱸������ M4(1,2,3) �� �����

    public static void Main()
    {
        // M2���� ���ڸ� 2���� ������ ��
        M2(1,2);   //ok
        M2(1, 2, 3); //error

        //������ ������ �������� �Ϸ��� �迭�� ������ ��
        M3( new int[] { 1, 2, 3 }); // int[] ar = new int[]{1,2,3} �̹Ƿ�
        M3 (new[] { 1, 2, 3 }); // int ar = new []{1,2,3}
        M3({1,2,3}); // �� ǥ����� error
        M3([1,2,3]);   // �� ǥ����� ���
        M3(1, 2, 3); // M3�� �迭�� ���ڷ� �ް� �ֱ� ������ error �߻�

        M4(new int[] { 1, 2, 3 });
        M4(1, 2, 3); // ���� 1,2,3�� �����Ϸ��� new int[]{1,2,3}���� ��������


    }

    // ���� ����
    public static void M5(int[] ar, int n) { } //ok			
    public static void M6(params int[] ar, int n) { }	//error

}
	