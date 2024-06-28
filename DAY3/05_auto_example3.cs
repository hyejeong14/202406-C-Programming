// 2�� ����
// 1�� ����

// auto implemented property vs public �ʵ�


class Person
{
    // �Ʒ� �ڵ�� �ʵ尡 �ƴ� �Ӽ�
    // => get,set �� �� ���� ������ ���� ����
    //public string Name { get; } //get only, setter ����. �����ڿ��� set ����

    public string Name { get; private set; } //setter�� ������ private���� ���� ����
                                             // �ڽ��� ��� �޼ҵ忡���� ���� �����ϴ� �ܺο����� ���� �ȵ�
    public string Address { get; set; }

    public Person(string name, string address)
    {
        Name = name;            //name�� get-only
                                //auto property�� �����ڿ��� ���� ����
                                //auto�� �ƴ� ���� �ʵ� �̸� ����ϸ� ��
                                //auto�� �ʵ� �̸��� �� �� �����Ƿ� �ʱ�ȭ�� ����ϱ� ����

        Address = address;      //
    }
}

class Program
{
    public static void Main()
    {
        Person p = new("kim", "seoul");

        // public �ʵ�� �׻� R/W �����մϴ�.
        //p.Name = "kim";      // error. R(get)�� ����
        string s = p.Name;    // ok get ����
        p.Address = "seoul"; // r/w����
    }
}


// �߰������� �Ӽ����� �����
// ��ü�� ���� ��� �Ӽ��� �ڵ����� �����ؼ� ����� �ִ� ���̺귯������ ����
// "Name, Address" �� �ʵ�� ����� �Ʒ��� ���� ��� ����� �� ����, public �ʵ忩�� ��ã��

//�Ʒ� �ڵ�� WPF ���̺귯�� ����
//DataGrid g = new DataGrid();
//g.Add(p); //p�� ���� �Ӽ��� ��� ���� �ڵ����� �����ִ� ���