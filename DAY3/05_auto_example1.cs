
// auto implemented property vs public �ʵ�


class Person
{
    // �Ʒ� �ڵ�� �Ӽ��� �ƴ϶� "public �ʵ�" �Դϴ�.
    public string Name;
    public string Address;

    public Person(string name, string address)
    {
        Name = name;
        Address = address;
    }
}

class Program
{
    public static void Main()
    {
        Person p = new();

        // public �ʵ�� �׻� R/W �����մϴ�.
        p.Name = "kim";
        p.Address = "seoul";
    }
}