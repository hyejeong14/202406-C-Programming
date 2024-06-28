using static System.Console;

//value type을 ref나 out 없이 전달하면 원본 인자의 수정이 불가하기 때문에 안전하다
// 하지만 크기가 큰 value type 이라면 복사본에 대한 오버헤드가 있다.
// 복사본에 대한 오버헤드를 없애려면 포인터만 보내면 되도록 ref를 사용하면 된다. 메모리 주소만 저장하면 되므로 메모리 오버헤드 제거 가능
// 하지만 이 경우 함수 안에서 원본 인자 수정이 가능해지면서 안전성이 떨어짐

class Program
{
    public static void RefParameter(ref int x)
    {
        x = 10; // x는 reference, 가리키는 곳을 읽고 쓰는 것이 가능
    }
    public static void Inparameter(in int x)
    {
        x = 10; //x는 reference, 가르키는 곳을 읽는 것만 가능. 따라서 x=10; 처럼 쓰기 구문은 error가 발생
        int n = x; //읽기는 가능
    }

    public static void Main()
    {
        int n = 0;
        
        RefParameter(ref n); // ok
        RefParameter(n); // error, ref 인자는 반드시 ref르 붙여야 함, 호출자 입장에서 바뀐다는 것을 명확히 알아야 함
        Inparameter(n);  // ok, InParameter는 In 생략이 가능
        Inparameter(in n); // ok
        WriteLine(n);
    }
}






/*
 * ﻿// 07-1_ref_readonly1.cs
using static System.Console;

// #1. value type 을 "ref, out" 없이 전달하면
// => 원본인자를 수정할수 없습니다.
// => "안전합니다."

// #2. 그런데, "크기가 큰 value type" 이라면 복사본에 대한 오버헤드
//     가 있습니다.
// #3. ref 로 전달하면 "복사본"에 대한 메모리 오버헤드를 제거할수 있습니다.
// => 이 경우, 함수안에서 "원본 인자"를 수정할수있게 됩니다.
// => 안전성이 떨어 집니다.
// => C++ 은 이럴때 "const reference" 를 사용합니다.
// => C# 7.0 에 이 개념이 추가되었습니다.

// C#1.0 : ref, out 도입
// C#7.0 : in 도입 - C++의 const reference 

// #4. in parameter 를 사용하면 "읽기전용 reference" 로 전달 할수 있습니다.

class Program
{
    public static void RefParameter(ref int x)
    {
        x = 10; // x는 reference!!
                // 가리키는 곳을 R/W 가능
    }
    public static void InParameter(in int x)
    {
        // x 는 reference, 가리키는 곳을 읽기만 가능
//      x = 10;    // error
        int n = x; // ok
    }

    public static void Main()
    {
        int n = 0;

        RefParameter(ref n); // ok
        RefParameter(n);     // error. ref 인자는 반드시 ref 붙여야 합니다.
                             // 호출자 입장에서 "바뀐다는 것은 명확히 알아야합니다."

        InParameter(in n);  // ok
        InParameter(n);     // ok. in 생략 가능. 변하지 않으므로 
                            //                   in 적지 않아도 위험하지 않습니다.
        WriteLine(n);    
    }
}*/