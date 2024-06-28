using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry"); }
}

class Dog : Animal
{
    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Cat : Animal
{
    public new void Cry() { WriteLine("3. Cat Cry"); }
}


class Program
{
    public static void Main()
    {
        // 73page.
        // 핵심 #1. 사용자 입력에 따라 다른 객체를 만들려면
        //          참조를 Animal 타입으로 해야 합니다.
        Animal a;

        int n = int.Parse(Console.ReadLine() ?? "0");

        if (n == 1)
            a = new Dog();
        else
            a = new Cat();

        // 핵심 #2. 컴파일러는 아래 코드를 컴파일 할때
        // 1. a가 가리키는 곳에 어떤 종류(Dog, Cat) 의 객체가 있는지 알수 없습니다.
        //    => 실행시간 입력 값에 따라 결정되므로
        // 2. 컴파일러가 아는 것은 "a라는 참조 자체는 Animal 타입" 이라는 것!!
        a.Cry();
    }
}

// "a.Cry()" 를 어떤 함수와 연결할것인가 ?
// => 함수 바인딩(function binding) 이라고 합니다.

// 핵심 2 
//컴파일러는 아래 코드를 컴파일 할 때 a가 가리키는 곳에 어떤 종류 (Dog or Cat)의 객체가 있는지 알 수 없다
//실행시간 입력 값에 따라 결정되므로!
//컴파일러가 아는 것은 
a.Cry();
       

        // 핵심 3. 함수 바인딩의 종류
        // 1.static binding : 컴파일러가 컴파일 시간에 함수 호출을 결정
        //                    컴파일러는 a가 가리키는 객체의 종류는 알 수 없음
        //                    단지, "a"가 Animal 이라는 것만 알 수 있음.
        //                    따라서, 컴파일러가 결정하면 Animal Cry 호출
        //                    비논리적이지만 빠름, cpp의 기본 바인딩 정책

        // 2. dynamic binding : 컴파일 시에는 a가 가리키는 곳을 조사하는 기계어 생성
        //                      실행시 메모리를 조사해서 실제 있는 객체에 따라 호출 결정
        //                      a가 가리키는 곳에 Dog 객체가 있다면 Dog Cry 호출
        //                      static binding보다 논리적이지만 느리고 성능 저하가 발생할 수 있음.
        //                      Java, Python의 기본 바인딩 정책

    }
}
