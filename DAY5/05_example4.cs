using static System.Console;

class Program
{
    public static int MyComparer(int a, int b)
    {
        //		return a.CompareTo(b); // 오름 차순
        return b.CompareTo(a); // 내림 차순
    }

    public static void Main()
    {
        int[] x = { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };

        // 핵심 : 배열의 모든 요소를 정렬하기.
        //		Array.Sort(x);	// 오름 차순 1,2,3,4,5,6,7,8,9,10

        // 정렬의 기준을 변경하려면 2번째 인자로 2항 메소드 보내면 됩니다.
        // 구글 "C# Array.Sort" 에서 MS 사이트 
        Array.Sort(x, MyComparer);



        foreach (var e in x)
            Write($"{e}, ");
    }

}
