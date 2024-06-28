using static System.Console;

class CPoint
{
    public int x;
    public int y;
    public CPoint(int a, int b) { x = a; y = b; }
}
struct SPoint
{
    public int x;
    public int y;
    public SPoint(int a, int b) { x = a; y = b; }
}
class Program
{
    public static void Main()
    {
        // 아래 cp1, cp2 와 sp1, sp2의 메모리 그림을 생각해보세요
        // 28 page 왼쪽 그림을 완벽히 이해해야 합니다.
        CPoint cp1 = new CPoint(1, 1);
        CPoint cp2 = cp1; // cp1이 가진 객체의 주소를 cp2에 복사한것

        cp1.x = 2;

        WriteLine($"{cp1.x}, {cp2.x}");
        // 2


        SPoint sp1 = new SPoint(1, 1);
        SPoint sp2 = sp1;   // sp1과 다른 sp2 객체를 생성하는데
                            // sp1 의 멤버의 내용을 복사 한것


        sp1.x = 2;
        WriteLine($"{sp1.x}, {sp2.x}");

    }
}
