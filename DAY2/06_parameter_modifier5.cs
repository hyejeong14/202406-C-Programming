using static System.Console;

class Program
{
    public static void Main()
    {
        //		string s = "10";
        string s = "ABC";

        //      int n = int.Parse(s); // s �� int�� ���� �Ұ����ϸ�
        // runtime error (����) �߻�. 

        // C# �޼ҵ��� Ư¡
        // "Try" �� �����ϴ� �޼ҵ�� ����/���� ���θ� ��ȯ�ϰ�
        // ������ ����� out parameter�� �˷� �ݴϴ�.
        bool b = int.TryParse(s, out int n);
        // ���н� false ��ȯ�ϰ�
        // n �� ����Ʈ ������ ä�� �ݴϴ�.

        Console.WriteLine($"{b} {n}");
    }
}