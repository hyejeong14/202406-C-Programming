using System;

Console.Write("input 1 >> ");
string s = Console.ReadLine();	 
Console.WriteLine(s);			 


Console.Write("input 2 >> ");
int n = Console.Read();			// 입력대기
							    // "ABCD" 입력
Console.WriteLine("{0}, {1}", n, (char)n); 	//"A"


Console.Write("input 2 >> ");
n = Console.Read();		// 대기 없음.
Console.WriteLine("{0}, {1}", n, (char)n);	// "B"
 

