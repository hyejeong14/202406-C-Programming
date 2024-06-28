using System;
using static System.Console;

string s1 = "AB";
string s2 = s1;

WriteLine($"{s2[0]}"); // 'A'


//object 클래스의 static method 인
// ReferenceEqual()을 사용하면
// 2개의 레퍼런스 변수가 같은 객체를 가르키는지 조사 가능

WrtieLine($"{object.ReferenceEquals(s1, s2)}"); // true


s2[0] = 'X'; // error
s2 = "XY";  // 새로운 객체를 생성 new string("XY")
WrtieLine($"{object.ReferenceEquals(s1, s2)}"); // false
WriteLine(s1,s2 ); //"AB","XY"
