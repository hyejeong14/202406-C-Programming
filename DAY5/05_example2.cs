using static System.Console;

// Predicate(조건자) : bool 을 반환하는 메소드
//                    검색조건등을 담은 함수를 만들때 사용
//                    대부분의 언어에서 "predicate" 용어 사용
delegate bool Predicate(int n);

class Program
{
    public static bool IsEven(int n) => n % 2 == 0;

    public static void Main()
    {
        int[] x = { 1, 8, 6, 4, 3 };

        int ret1 = Array.FindIndex(x, IsEven);
        int ret2 = MyFindIndex(x, IsEven);

        WriteLine($"{ret1} {ret2}"); // 1, 1
    }

    // Array.FindIndex 를 직접 만들어 봅시다.
    public static int MyFindIndex(int[] arr, Predicate match)
    {
        int sz = arr.Length;

        for (int i = 0; i < sz; i++)
        {
            if (match(arr[i]))
                return i;
        }

        return -1;
    }
}