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

// C# 의 switch 는 아주 막강합니다. 
// => "패턴 매칭"기능이 뛰어 납니다
object obj = num; // 모든 변수는 object 타입으로 가리킬수 있다.
                  // "object" 항목에서 자세히
/*
switch (obj)
{
    // 아래 case 문은 "값" 이 아닌 "타입" 조사 라는 것이 핵심 입니다.
    case int: Console.WriteLine("int"); break;
    case double: Console.WriteLine("double"); break;
    default: Console.WriteLine("other"); break;
}*/