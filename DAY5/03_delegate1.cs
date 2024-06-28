using System;
using static System.Console;

// delegate ����� ��
// 1. Method ����ο� �����ϰ� �ڵ��ϰ�
// 2. ��ȯ Ÿ�Ծտ� delegate ���̰�
// 3. �޼ҵ� �̸��� "���ϴ� �̸�(Ÿ���̸�)" ���� ����
// => �Ʒ� �ڵ忡�� "MyFunc" �� �޼ҵ� ������ ��� Ÿ���Դϴ�.

delegate void MyFunc(int arg);

class Program
{
    public static void Foo(int arg) { WriteLine($"Foo : {arg}"); }

    public static void Main()
    {
        int n = 10;
        double d = 3.4;
        string s = "abc";

        //		? f = Foo;	// ? ��ġ���� �޼ҵ��� ������ �����ϴ� Ÿ���� �ʿ�
        // (�޼ҵ��� �޸� �ּҿ� ���� �������� ����)
        // "delegate" �� �޼ҵ��� ������ �����ϴ� Ÿ��
        // C/C++ �� �Լ� ������

        MyFunc f = Foo;

        f(10); // Foo(10) �� ����
    }


}