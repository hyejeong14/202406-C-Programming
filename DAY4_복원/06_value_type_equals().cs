// equals1 복사
using static System.Console;

class CPoint
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public CPoint(int a, int b) => (X, Y) = (a, b);
}
struct SPoint
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public SPoint(int a, int b) => (X, Y) = (a, b);
}

class Program
{
    public static void Main()
    {
        CPoint cp = new CPoint(1, 2);
        SPoint sp = new SPoint(1, 2);

        ShowType(cp);
        ShowType(sp);
    }

    // cmc.cs 파일 안에 보면 ShowType 이라는 static method 있습니다
    // 복사해 오세요
    public static void ShowType(object? obj)
    {
        if (obj == null)
        {
            WriteLine("ShowType : error. null reference");
            return;
        }

        Type? t = obj?.GetType();
        Type? objType = typeof(object);

        while (true)
        {
            Write($"{t?.Name}");

            if (t == objType) break;
            Write(" -> ");
            t = t?.BaseType;
        }
        WriteLine();
    }

}