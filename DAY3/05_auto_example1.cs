
// auto implemented property vs public 필드


class Person
{
    // 아래 코드는 속성이 아니라 "public 필드" 입니다.
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

        // public 필드는 항상 R/W 가능합니다.
        p.Name = "kim";
        p.Address = "seoul";
    }
}