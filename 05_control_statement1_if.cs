using System;

int num = 1;

switch (num)
{
    case 0:
        Console.WriteLine("0");
        break;
    case 1:
        Console.WriteLine("1");
        break;
    default:
        Console.WriteLine("other");
        break;
}

// C# �� switch �� ���� �����մϴ�. 
// => "���� ��Ī"����� �پ� ���ϴ�
object obj = num; // ��� ������ object Ÿ������ ����ų�� �ִ�.
                  // "object" �׸񿡼� �ڼ���
/*
switch (obj)
{
    // �Ʒ� case ���� "��" �� �ƴ� "Ÿ��" ���� ��� ���� �ٽ� �Դϴ�.
    case int: Console.WriteLine("int"); break;
    case double: Console.WriteLine("double"); break;
    default: Console.WriteLine("other"); break;
}*/