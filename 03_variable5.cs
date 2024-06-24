using static System.Console;

// #1. casting
double d = 3.4;
//int n1 = d;	        // error. 데이타 손실 발생. 
int n2 = (int)d;    // ok.    캐스팅은 C언어와 유사한 방식
                    // is 등의 연산자를 사용해도 되는데, 뒤에 등장..


// #2. nameof
int color = 100;

WriteLine($"color : {color}");
WriteLine($"{nameof(color)} : {color}");

// nameof(color) : "color" 로 변환
// 즉, 변수 이름을 "문자열"로 변경하는 키워드

string s = "abcd";
WriteLine($"{nameof(s.Length)} :  {s.Length}"); // "s.Length : 4"

// 변수, 속성(property), 타입이름등에 nameof 사용가능.