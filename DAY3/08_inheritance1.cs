// #1. 상속을 사용하지 않는 경우
// => name, age 가 중복된다.
/*
class Student
{
    private string name;
    private int age;
    private int id;
}
class Professor
{
    private string name;
    private int age;
    private int major;
}
*/
// #2. 상속을 사용하는 코드
//객체 지향의 3대 특징 : "캡슐화", "상속", "다형성"

// 모든 사람의 공통을 특징을 먼저 설계하고
class Person
{
    private string name;
    private int age;
}

// 기존 클래스(Person)을 확장해서 새로운 클래스(타입)을 설계하는 문법
class Student : Person
{
    private int id;
}

class Professor : Person
{
    private int major;
}

class Program
{
    public static void Main()
    {
        Student s = new Student(); // name, age, id를 가진 객체 생성
    }
}

//거의 모든 객체지향 언어는 상속을 지원.
//C#     : class Student : Person{}
//c++    : class Student : public Person{}
//Java   : class Student extends Person{}
//Python : class Student(Person)