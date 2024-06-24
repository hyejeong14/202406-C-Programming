using System;

//모든 언어에서 사용자 입력은 "문자열"일 뿐
//  => 사용자가 10을 입력하는 것은 "10"이라는 문자열 입력
//  => 입력된 문자열을 정수로 변경해서 사용해야 함

// 변경을 입력 함수가 해주는 경우
//  => C/C++,Java 
//  scanf("%d",&n) : scanf 가 "문자열"을 정수로 변환해 주는 것 (C의 경우)

//개발자가 직접 하는 경우
//  => C#

// 문자열이 아닌 정수를 입력 받는 방법.
//  => C#



Console.Write("input yout age >> ");

string s = Console.ReadLine(); // "10"

//사용자가 직접 변환을 해주는 과정이 필요함
int n = Convert.ToInt32(s);

Console.WriteLine(n);




