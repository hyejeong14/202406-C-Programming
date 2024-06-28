using static System.Console;

class Program
{
    public static void Main()
    {
        // 배열을 크기를 변경 할수 없습니다.
        // => 아래 배열은 5개 까지만 보관할수 있습니다.
        // => 더이상 "추가" 할수 없습니다.
        int[] arr = new int[5] { 1, 2, 3, 4, 5 };

        //		arr.Add(6); // error. 배열은 이런 메소드가 없습니다


        // 요소를 계속 추가하고 싶다면 다양한 Collection 을 사용하면 됩니다.
        List<int> list = new List<int>();   // Python 의 list 같은 도구
                                            // list = [];

        list.Add(1);
        list.Add(2);
        list.Add(3);

        // list 에 요소가 몇개 인지 출력해 보세요
        WriteLine(list.Count);
    }
}