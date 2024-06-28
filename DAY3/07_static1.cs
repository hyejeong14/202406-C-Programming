using static System.Console;

// 핵심
// instance field : 객체당 한개, "객체이름.필드이름" 으로 접근
// static field   : 클래스당한개, "클래스이름.필드이름" 으로 접근

class Car
{
    public int Color { get; set; } = 0;

    //  public int Count = 0;   // instance field
    // 객체당 한개씩 생성된다.
    // 객체의 고유한 속성을 저장하기 위한것
    // 각 자동차의 색상, 속도등...

    public static int Count = 0; // static field
                                 // 모든 Car 객체가 공유하는 멤버
                                 // 각각의 객체가 아닌 "Car 클래스 자체의 속성" 관리
                                 // 객체이름이 아닌 "클래스이름.Count"로 접근

    public Car() { ++Count; }
}

class Program
{
    public static void Main()
    {
        Car c1 = new Car();
        Car c2 = new Car();

        // Car 타입의 객체가 몇개나 생성되었는지 알고 싶다.

        //      WriteLine( c1.Count ); // instance field 접근
        WriteLine(Car.Count); // static field 접근
    }
}