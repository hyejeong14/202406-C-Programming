using static System.Console;

// �Ŀ� ����Ʈ ���� ���α׷��� ��ü���� ���� ����� ���� ������ ���ô�.

// 1. ��� ������ Ÿ������ �����ϸ� ���մϴ�
// 2. ��� ������ ������ ��� Ŭ������ �ִٸ�
//    ��� ���� ��ü�� �ϳ��� �÷��ǿ� ��� ���� �����մϴ�.

class Shape
{
}

class Rect : Shape
{
    // int x, y, w, h, �����ڵ��� ����, �ִٰ� �����ϰ� �����Լ��� ����������

    public void Draw() { WriteLine("Draw Rect"); }
}
class Circle : Shape
{
    public void Draw() { WriteLine("Draw Circle"); }
}

class Program
{
    public static void Main()
    {
        //		List<Rect> list = new List<Rect>(); // Rect ��ü�� ��������
        //      List<object> list = new List<object>(); // ��� ��ü�� ��������

        List<Shape> list = new List<Shape>(); // ��� ������ ��������
    }
}