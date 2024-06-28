// 24 page ~ 


/*
 
//C/C++/Java
//1. Int 타입의 변수에는 멤버 함수 등의 개념이 존재하지 않음
int n1 = 10;
n1.foo(); //error

//2. struct/class로 만들면 멤버함수, 멤버 데이터 등을 넣을 수 있음
struct Point
{
    int x, y;
    void print()
    {

    }
}

Point pt;
pt.print();

 
*/



// 핵심 : 모든 것은 객체이다.

using System;

int n1 = 10;
string s1 = n1.ToString(); //n1이 가진 값(10)을 문자열로 반환하는 메소드
string s2 = 10.ToString(); //literal 10도 int타입으로 메소드를 가지고 있음

//용어정리
// n1 : 변수 또는 객체라고 함
// 객체 n1과 관련된 함수
// C++ : "멤버함수"라고 부름
// Java, C#, Python 등 : "메소드"라고 함