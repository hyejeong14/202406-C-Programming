using System;
using static System.Console;


// #1. delegate1.cs 를 통해서 "delegate 만드는 법" 알아 두세요

// #2. 정확한 원리

delegate void MyFunc(int arg);

/*
// 위 한줄을 보고 컴파일러가 아래 클래스 생성
class MyFunc : MulticastDelegate
{
    // void를 반환하고 인자가 int 한개인 메소드의 주소 보관했다가
    // 호출하기 위한 코드를 자동생성
    // Invoke() 같은 메소드도 추가됨
}
*/


class Program
{
    public static void Foo(int arg) { WriteLine($"Foo : {arg}"); }

    public static void Main()
    {
        // #3. 결국 MyFunc 는 클래스 입니다.
        MyFunc f1 = new MyFunc(Foo); // delegate 를 사용하는 정확한 표기법
        MyFunc f2 = Foo;             // 편의 표기법을 제공하는 것!

        // #4. delegate 객체로 메소드 호출하기
        f2(10);         // () 연산자 사용
        f2.Invoke(10);  // 이렇게도 가능
    }


}

