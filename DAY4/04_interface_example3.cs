// 2번복사
using static System.Console;

class Program
{
    public static void Main()
    {
        int n1 = 0;
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1;
        //int[] arr3 = arr1.Clone(); // 클론할 객체의 복사본으로 새로운 객체를 만들고 그 곳을 가리키는 형태가 됨.
        // 즉, arr1과 arr2는 같은 객체, arr3는 다른 객체가 된다
        //error! 아래와 같이 해결하면 된다 캐스팅하기

        int[] arr3 = (int[])arr1.Clone();

    }
}