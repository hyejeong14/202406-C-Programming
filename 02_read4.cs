using System;

Console.Write("press any key >> ");

int n = Console.Read();    // 입력 버퍼에서 꺼내기
                           // 입력 버퍼가 비어 있다면
                           // "키보드-> 입력버퍼"의 내부 루틴을 실행
                           // 즉, enter를 실행할 때까지 대기

//입력 버퍼가 아닌 "키보드로부터 직접 꺼내기"
//  => enter 필요없이 아무키나 누르면 즉시 반환
Console.Write("press any key (ReadKey) >> ");
//ConsoleKeyInfo cki = Console.ReadKey();
//  => 입력된 문자가 echo됨
ConsoleKeyInfo cki = Console.ReadKey(true); //입력된 문자가 echo되지 않음
Console.WriteLine(cki.KeyChar);

