using static System.Console;


// Sort 에 비교 정책으로 전달하기 위한 객체는 반드시
// IComparer<T> 를 구현해야 합니다.
class MyComp : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return x.CompareTo(y);
    }
}


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

        // Sort 등을 사용할때 비교 정책을 변경하는 방법

        // #1. Sort 메소드 인자로 "약속된 모양의 메소드 전달" - delegate 방식   
        Array.Sort(x, MyComparer);


        // #2. Sort 메소드 인자로 "약속된 함수를 구현한 객체 전달"
        MyComp mc = new MyComp();
        Array.Sort(x, mc);



        foreach (var e in x)
            Write($"{e}, ");
    }

}
