// auto-implemented property
class Example
{
    private int data1 = 0;
    
    //�ʵ� �Ѱ��� ����� Property�� ����� �������� �ڵ�� �Ʒ��� ����
    public int Data1 
    { 
        get { return data1; } 
        set { data1 = value; } 
    }

    //�� �ڵ忡�� set, get�� ��� �߰����� �������� ���� �ʵ带 ���� r/w (read&write) �ϰ� ����

    // �Ʒ� ������ �� �ڵ�� ������ ����
    // => �ʵ� �߰��ǰ�(�̸��� �� �� ����), setter, getter �߰�
    // => auto implemented property ��� ��

    public string Name;
    public string Address;

    public
}

class Program
{
    
    public static void Main()
    {

    }
}
