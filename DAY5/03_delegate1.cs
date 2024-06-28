using System;
using static System.Console;

// delegate 만드는 법
// 1. Method 선언부와 동일하고 코딩하고
// 2. 반환 타입앞에 delegate 붙이고
// 3. 메소드 이름을 "원하는 이름(타입이름)" 으로 변경
// => 아래 코드에서 "MyFunc" 가 메소드 정보를 담는 타입입니다.

delegate void MyFunc(int arg);

class Program
{
    public static void Foo(int arg) { WriteLine($"Foo : {arg}"); }

    public static void Main()
    {
        int n = 10;
        double d = 3.4;
        string s = "abc";

        //		? f = Foo;	// ? 위치에는 메소드의 정보를 저장하는 타입이 필요
        // (메소드의 메모리 주소와 인자 갯수등의 정보)
        // "delegate" 가 메소드의 정보를 저장하는 타입
        // C/C++ 의 함수 포인터

        MyFunc f = Foo;

        f(10); // Foo(10) 과 동일
    }


}