// 1
using static System.Console;

class Button
{
    public void UserPressButton()
    {
        // ��ư�� �������� �ؾ�������
        // ���⼭ �����ϰ� �Ǹ�
        // ��� ��ư�� ���� ���� �ϰ� �˴ϴ�.
        WriteLine("To Do Something");
    }
}

class Program
{
    public static void Main()
    {
        Button btn1 = new Button();
        Button btn2 = new Button();

        btn1.UserPressButton(); // ����ڰ� ��ư�� �����ٰ� ����	
        btn2.UserPressButton();
    }
}
