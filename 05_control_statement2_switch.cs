using System;

int num = 1;

switch(num)
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


//C#�� Switch�� ���� ��Ī ����� ���� �پ
object obj = num;

switch (obj)
{
    case int:
        Console.WriteLine("int");
        break;
    case double:
        Console.WriteLine("double");
        break;
    default:
        Console.WriteLine("other");
        break;
}
