using System;
using static System.Console;

//아래 두 줄은 동일 
// int {var name} = new int(); 형식이 정석이지만 개발자의 편의를 위해 int {var name} = var; 형식도 지원하는 것
// 하지만 객체의 타입에 따라 위가 허용되지 않는 경우도 있음
int n1 = 0;
int n2 = new int();

//아래 4줄은 차이가 있음
string s1 = new string("AAA"); //"AAA"라는 새로운 객체를 생성
string s2 = new string("AAA"); //"AAA"라는 새로운 객체를 생성
                               // s1,s2는 서로 다른 객체를 가르킴

string s3 = "BBB"; //new string("BBB")
string s4 = "BBB"; //string은 immutable한 객체
                   //이미 immutable한 BBB가 존재하므로 해당 객체를 공유하게 됨.
                   //s3,s4가 BBB 객체를 공유
                   //string은 immutable한 객체이기 때문에 위의 new 로 생성하는 방식보다는 아래와 같은 방식이 권장됨
                   //memory 부하를 줄이기 위함
                   //공유되는 문자열이 있는 공간을 'intern pool'이라고 함

WriteLine($"s3(BBB) vs s4(BBB) : {object.ReferenceEquals(s3, s4)}");


string s5 = Console.ReadLine(); //BBB입력
WriteLine($"s3(BBB) vs s5({s5}) : {object.ReferenceEquals(s3, s5)}"); ///s5에 BBB 입력시 false 출력 new 객체 이기 때문인가방
