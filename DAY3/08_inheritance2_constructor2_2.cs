//사용자가 생성자를 만들지 않으면 컴파일러가 default 생성자 (인자가 없는 생성자)를 만들어 줌
class Person
{
    private string name;
    private int age;

    // 생성자 규칙 정리
    // #1. 객체를 생성하면 반드시 생성자가 호출된다
    // #2. 사용자가 생성자를 한개도 생성하지 않으면 컴파일러가 디폴트 생성자이 인자가 없는 생성자를 하나 제공한다.
    // #3. 사용자가 생성자를 한개라도 생성하면 (인자의 여부 상관없이) 컴파일러는 디폴트 생성자를 제공하지 않는다 


    //    public Person();
    public Person(string n, int a) => (name, age) = (n, a);

}


// Person 으로 부터 상속받는 Student 만들어 보세요 
// 1. int id 추가해 보세요
// 2. Student 생성자 만들어 보세요
// 3. Main 에서 Student 객체 생성해 보세요

class Program
{
    public static void Main()
    {
        Person p = new Person(); //person 클래스에 public Person(string n, int a) => (name, age) = (n, a); 해당 생성자가 제공된다면
                                 // 해당 코드는 error
                                 //person 클래스에 인자가 없는 생성자는 없기 때문
    }
}
