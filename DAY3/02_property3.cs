class Person
{
    private int age;

    // �Ʒ� �ڵ带 ���� �����Ϸ���
    // => set_Age(int value), get_Age() �޼ҵ带 ����
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}

class Program
{
    public static void Main()
    {
        Person p1 = new Person();

        // Property �� ����
        p1.Age = 10;     // �����Ϸ��� p1.set_Age(10) ���� ����   

        int n = p1.Age;  // p1.get_Age() �� ����   


        Console.WriteLine(n);

    }
}