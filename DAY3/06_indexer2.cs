class Example
{
    // �ʵ�� ������ �׻� 0�� ��ȯ�ϴ� �Ӽ�
    public int Data1 { get => 0; }

    // �Ʒ� main �� ���������� �ʰ� �� �κ� ����� ������.
    // => ��� 0 ��ȯ�� ������.
    public int this[int idx]
    {
        get => 0;
    }
    public int this[string idx]
    {
        get => 0;
    }
    public int this[int idx1, int idx2]
    {
        get => 0;
    }
    public int this[int idx1, string idx2]
    {
        get => 0;
    }
}

class Program
{
    public static void Main()
    {
        //      Example e = new Example();
        Example e = new();  // ���ڵ带 �̷��� �ص� �˴ϴ�.
                            // �º��� ���� �캯�� Ÿ���� �߷� �˴ϴ�.

        int n1 = e.Data1; // 0

        int n2 = e[0];
        int n3 = e["A"];
        int n4 = e[0, 1];
        int n5 = e[0, "A"];
    }
}