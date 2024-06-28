using static System.Console;

delegate void MyFunc(int arg);

class Program
{
    public static void SMethod(int arg) => WriteLine("SMethod");
    public void IMethod(int arg) => WriteLine("IMethod");

    public static void Main()
    {
        // #1. ���� ������ "�ٸ� Ŭ������ �޼ҵ带 ����ϴ� ����"

        // #2. �̹����� �ڽ��� static, instance method �̾߱�

        // ���� ���� ȣ��
        Program.SMethod(1); // ��Ȯ�� ǥ���. "Ŭ�����̸�.static �޼ҵ��̸�"
        SMethod(2);         // �ڽ��� �޼ҵ忡���� "Ŭ�����̸� ��������"

        //		IMethod(1); // error. instance method �� ��ü�� �ʿ�

        Program p = new Program();
        p.IMethod(1); // ok


        // �� �ڵ带 �߻����� ���� �Ʒ� ? �� ok. error �� ä�켼��
        // error �� ���, ������ ������
        MyFunc f1 = Program.SMethod; // ?
        MyFunc f2 = SMethod;         // ?
        MyFunc f3 = IMethod;         // ?

        p.InstanceMethod();
    }

    public void InstanceMethod()
    {
    }
}