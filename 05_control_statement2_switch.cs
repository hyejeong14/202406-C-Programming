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


//C#의 Switch는 패턴 매칭 기능이 아주 뛰어남
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
