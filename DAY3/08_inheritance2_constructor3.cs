class Person
{
    private string name;
    private int age;

    public Person(string n, int a) => (name, age) = (n, a);
}

// Person 으로 부터 상속받는 Student 만들어 보세요 
// 1. int id 추가해 보세요
// 2. Student 생성자 만들어 보세요
// 3. Main 에서 Student 객체 생성해 보세요

class Student : Person
{
    private int id;

    // 사용자 코드가 public Student(int n)이면 컴파일러가 자동으로 public Student(int n) : base() 으로 변경 base는 키워드임~
    
    //기반 클래스에 디폴트 생성자가 없으므로 반드시 개발자가 명시적으로 호출해야 함
    public Student(String n, int a,int i) : base(n,a) {
        id = i;

}
}
class Program
{
    public static void Main()
    {
        Student s = new Student("Kin", 20, 1);
    }
}