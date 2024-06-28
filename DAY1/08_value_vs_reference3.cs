// 1번 복사
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
        CPoint cp1; //객체 생성이 되지 않음, reference(포인터)만 생성
        SPoint sp1; //객체는 생성됐지만 생성자는 호출이 되지 않음
        SPoint sp2 = new SPoint(1, 1); //객체 생성되고 생성자 호출됨

        cp1.x = 1; //error 발생 객체가 없음

        int n1 = sp1.x; //error. 초기화되지 않은 변수를 읽음
        sp1.x = 1; // 초기화되지 않아도 쓰기는 가능

        int n2 = sp2.x; //가능

        int a1; //초기화 안됨
        int a2 = a1; // error
        a1 = n2; // 가능
       

    }
}