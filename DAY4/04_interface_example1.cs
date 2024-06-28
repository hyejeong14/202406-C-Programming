
using static System.Console;

class Program
{
    public static void Main()
    {
        int n1 = 10;
        int n2 = 20;

        string s1 = "AAA";
        string s2 = "BBB";

        // 객체의 크기 비교 방법

        // 방법 #1. 비교 연산자 (<, > 사용)
        bool b1 = n1 < n2; // ok. 수치 타입은 가능
                           //      bool b2 = s1 < s2; // error. string 은 지원안함

        // 방법 #2. CompareTo 메소드

        int ret1 = n1.CompareTo(n2); // n1 이 크면 양수, 작으면 음수, 같으면 0
        int ret2 = s1.CompareTo(s2); // string 도 지원.

        // 핵심 : C#이 제공하는 타입에서  크기 비교가 가능한 모든 타입은
        //        "CompareTo" 메소드 있습니다.

        IComparable c = s1;
    }



    //public static void Foo(object arg) //int 개게만 받겠다는 의미
    //public static void Foo(object arg) //모든 객체를 받겠다
    public static void Foo(IComparable arg) //CompareTo가 있는 것만 받겠다는 의미
    {
        //이 안에서 arg에 대해서 Compare To를 사용하게 됩니다.
        //CompareTo가 있는 객체만 인자로 받아야 한다면
    }

}