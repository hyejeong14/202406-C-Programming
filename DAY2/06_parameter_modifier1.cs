// 54 page ~ 
// "C언어의 call by value, call by reference" 에 대한 C# 방식

using static System.Console;

class Program
{
    // 아래 코드는 인자의 복사본이 생성됩니다. 55p 왼쪽 그림 참고
    // "call by value"
    // Inc1 에서 x를 수정해도 main 의 n 은 변경안됨
    public static void Inc1(int x) { ++x; }
    public static void Inc2(ref int x) { ++x; }

    public static void Main()
    {
        int n = 0;

        Inc1(n); // 의도 : n 을 1증가하고 싶다. - 55p 왼쪽그림
                 // 함수의 인자 전달은 함수가 사용할 지역변수를 만들면서
                 // 초기화 하는 과정, 즉, 아래 코드와 동일
                 // "int x = n" 
        WriteLine(n); // 0 

        Inc2(ref n);  // ref parameter 에 인자를 전달할때도 반드시 (ref -> reference 라는 뜻, 전달이나 받을 떼 ref를 꾹 둘다 붙여야 함)
                      // ref 를 표기해야 합니다.
                      // => 값이 아닌 reference 를 전달해 달라는것
                      // => 결국 메모리 주소 전달
        WriteLine(n); // 1 
    }
}