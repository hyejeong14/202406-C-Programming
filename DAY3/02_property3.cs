class Person
{
    private int age;

    // 아래 코드를 보고 컴파일러가
    // => set_Age(int value), get_Age() 메소드를 생성
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

        // Property 의 원리
        p1.Age = 10;     // 컴파일러가 p1.set_Age(10) 으로 변경   

        int n = p1.Age;  // p1.get_Age() 로 변경   


        Console.WriteLine(n);

    }
}