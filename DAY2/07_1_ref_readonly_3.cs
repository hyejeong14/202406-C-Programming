// 07-1_ref_readonly1.cs
using static System.Console;

// C#1.0 : ref, out 도입
// C#7.0 : in 도입 
// C#12.0: ref readonly

// #1. ref readonly 는 in 과 거의 동일합니다.
// => 단 한개의 차이(lvalue, rvalue 이야기)만 있습니다.

class Program
{
    public static void ValueParameter(int x)
    {

    }
    public static void RefParameter(ref int x)
    {

    }
    public static void InParameter(in int x)
    {
        
    }

    public static void RefReadonlyParameter(ref readonly int x)
    {
        
    }

    public static void Main()
    {
        int n = 0;
        ValueParameter(n); 
        RefParameter(ref n);            // ok
        InParameter(in n);              // ok in 생략 가능 (in으로 보내면 참조하는 것, 근데 읽기만 가능)
        RefReadonlyParameter(ref n);    // ok

        ValueParameter(3); // 변수 대신 literal 전달
                           // 변수는 lvalue (메모리가 있고, 이름이 있다)
                           // literal ( 메모리가 할당된게 아니라, 값만 )
        RefParameter(ref 3); // error, rvalue인 3을 ref로 전달할 수 없다
                             // 3은 메모리가 없음. 주소가 없다는 뜻
                             // ref로 보내는 것은 담아오겠다는 의도도 있다
                             // 메모리가 없으므로 담을 수 없다.
        InParameter(3); // ok
                        // 임시로 메모리가 한 개 할당되고 3으로 초기화 된다.
                        // 그리고, 임시메모리의 주소가 함수에 전달됨
                        // In 파라미터는 임시 객체가 생성될 수 있다는 특징이 있음
        RefReadonlyParameter(ref 3); // error
                                     // ref readonly는 lvalue만 전달 가능하다
                                     // 임시객체 생성에 따른 성능 저하를 막기 위해
        WriteLine(n);

    }
}