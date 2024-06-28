using System;
class Person
{
    private string name;
    private int age;

    //Name, Age 속성 제공
    public string Name
    {
        get => name;
        set => name = value;
    }
    
    public int Age
    {
        get => age;
        set => age = value; 
    }

    //Description 속성 제공
    public string Description
    {
        get => name + " " + age.ToString();
        
    }

    public Person(string n, int a)
    {
        Name = n;
        Age = a;
    }
}

class Program
{
    public static void Main()
    {
        Person p = new Person("Kim", 20);

        Console.WriteLine(p.Description);
    }
}