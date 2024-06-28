// 82 page
// public  : 외부에서 접근 가능
// private : 외부에서 접근 안됨. 메소드에서만 접근 가능

// 캡슐화(encapsulation)
// => 필드를 private 으로 보호해서 외부의 잘못된 사용으로 객체가 불안해 지는것을
// 막는다
// => 객체의 상태는 잘 정의된 메소드를 통해서만 변경가능하다
// => 객체의 상태가 불안해 지는 것을 막는다.

class Person
{
    //  public int age;  
    private int age;

    // public method 를 통해서만
    // 필드를 수정할수 있게 합니다.
    public void SetAge(int a)
    {
        // 인자 값의 유효성 여부를 확인해서
        // 유효한 경우에만 필드를 수정합니다.
        // => 이제 "age" 필드는 항상 유효한 값만 가질수 있게 되었습니다.
        if (a > 0 && a < 150)
            age = a;
    }

    public int GetAge() => age;
}

class Program
{
    public static void Main()
    {
        Person p1 = new Person();

        //      p1.age = -10;   // 사용자가 실수했다. 
        // private 이라면 error
        p1.SetAge(-10);

    }
}