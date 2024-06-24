using System;

//모든 입력은 입력 버퍼에서 꺼내게 됨.
//	=> 입력 버퍼가 비어 있으면
//	=> 키보드 입력을 입력 버퍼에 채우는 내부 루틴이 먼저 시행됨.

//Console.ReadLine : 입력 버퍼에서 "한줄" 꺼내기
//Console.Read : 입력 버퍼에서 "한문자" 꺼내기

Console.Write("input 1 >> ");
string s = Console.ReadLine();	 
Console.WriteLine(s);			 


Console.Write("input 2 >> ");
int n = Console.Read();			// 입력대기
							    // "ABCD" 입력
								// "A" 입력시는 "65,13,10"이 입력됨
								//				"A\r\n" 13은 엔터를 의미, 10은 carriage return?
								//				enter만 입력 시 "\r\n"
Console.WriteLine("{0}, {1}", n, (char)n); 	//"A"


Console.Write("input 2 >> ");
n = Console.Read();		// 대기 없음.
Console.WriteLine("{0}, {1}", n, (char)n);	// "B"
 

