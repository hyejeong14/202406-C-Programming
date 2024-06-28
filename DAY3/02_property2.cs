// property(속성) : setter 와 getter 를 쉽게 만드는 문법
// => 메소드 처럼 만들지만, 필드처럼 사용하게 됩니다.

// 코딩 관례
// 필드     : 모두 소문자로
// Property : 1글자를 대문자로
// Method   : 1글자를 대문자로
// class이름 :1글자를 대문자로

class Person
{
    private int age;

    // 아래 코드가 "property" 문법의 기본 코드입니다
    public int Age
    {
        get { return age; }
        set { age = value; }    // value 는 이 위치에서만 사용가능한 키워드입니다.
                                // "context keyword" 라고 합니다.
                                // 특정 위치에서만 사용가능한 키워드
    }
}

class Program
{
    public static void Main()
    {
        Person p1 = new Person();

        p1.Age = 10;        // 이순간 set 부분 실행
                            // value 에는 10 전달 

        int n = p1.Age;     // 이순간 get 부분 실행됨

        Console.WriteLine(n);

    }
}