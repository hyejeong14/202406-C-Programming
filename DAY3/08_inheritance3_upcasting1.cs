class Animal
{
    public int Age { get; set; } = 0;
}

class Dog : Animal
{
    public int Color { get; set; } = 0;
}

class Cat : Animal
{
    public int Speed { get; set; } = 0;
}

class Program
{
    public static void Main()
    {
        Dog d = new Dog();      // ok

        //      string s = new Dog();   // error. 전혀 상관없는 타입의
        // reference 로 Dog 객체를 가리킬수 없다.

        // 핵심 1. 기반 클래스 reference 로 파생 클래스 객체를 가리킬수 있다
        // => "upcasting" 이라고 합니다
        // => 가능한 이유는 "메모리 그림"을 생각해 보세요
        // 기반 클래스는 메모리 위에 존재.?

        // 핵심 2. Animal a = new Dog()일 때 a로는 Animal 고유의 멤버만 접근 가능
        // 이유 : a가 가르키는 객체는 실행 시 변경될 수 있으므로
        // if (사용자 입력값 == 1) a = new Cat();
        Animal a = new Dog();
        a.Age = 10 ;  //ok
        a.Color = 10; //error

        //핵심 3. "a"를 사용해서 Dog가 추가한 멤버에 접근하려면 casting이 필요함
        ((Dog)a).Color = 10;

        //Dog d2 = a; //error. a가 정말 Dog를 가르키는지 컴파일러가 알 수 없음
        // if(실행시간입력값 == 1) a = 다른 동물;
        Dog d2 = (Dog)a; //또는 이런 식으로
        d2.Color = 10;

        // 단 이때 a가 가리키는 곳이 Dog 라는 확신이 있어야 함
        // Dog 가 아닌 다른 객체라면 runtime error 예외가 발생함

    }
}