// 1번 복사
// 람다 장점
using static System.Console;

class Program
{
    static bool IsMultipleOf(int n) { return n % 3 == 0; } // 인자는 반드시 하나여야 한ㅁ

    public static void Main()
    {
        int[] array = { 1, 3, 6, 4, 5 };

        //아래 코드는 3의 배수를 찾는 코드
        int idx1 = Array.FindIndex(array, IsMultipleOf); //여기 두번째 인자는 !!!인자가 반드시 하나여야함!!!!

        int k = 4; //사용자가 입력한 값이라고 가정

        //배열 x에서 k의 배수 찾기
        // => IsMultipleOf를 활용하는 법?
        // => FindIndex의 2번째 인자는 반드시 인자가 하나여야 함
        // => IsMultipleOf가 인자 한개를 유지하면서 main의 지역변수인 k를 사용할 수 없음
        // 즉, 일반 메소드는 Main의 지역변수 접근이 안됨
        // 하지만 람다는 된다!
        // => 람다표현식 안에서는 자신이 포함된 함수의 지역변수를
        //    접근할수 있습니다.
        int idx2 = Array.FindIndex(array, n => n % k == 0);


    }
}
