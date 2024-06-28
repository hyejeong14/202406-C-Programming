// 1
using static System.Console;

class Button
{
    public void UserPressButton()
    {
        // 버튼을 눌렀을때 해야할일을
        // 여기서 직접하게 되면
        // 모든 버튼은 같은 일을 하게 됩니다.
        WriteLine("To Do Something");
    }
}

class Program
{
    public static void Main()
    {
        Button btn1 = new Button();
        Button btn2 = new Button();

        btn1.UserPressButton(); // 사용자가 버튼을 누를다고 가정	
        btn2.UserPressButton();
    }
}
