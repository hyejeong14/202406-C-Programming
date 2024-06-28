using System;


int num = 1;

switch (num)
{
    // 아래 처럼 만드는 것은 허용됩니다.
    case 0:
    case 1:
        Console.WriteLine("1");
        break;

    case 2:
        Console.WriteLine("2");
        // break;   // 의도적인 break 의 생략 - fallthrough 라고 합니다.
        // C/C++ 가능, C#/Rust 에러
        // fallthrough  // RUST 는 이렇게 적어야 합니다.
        goto case 3;    // C#은 이렇게 하면 됩니다.

    case 3:
        Console.WriteLine("3");
        break;


    default:
        Console.WriteLine("other");
        break;
}