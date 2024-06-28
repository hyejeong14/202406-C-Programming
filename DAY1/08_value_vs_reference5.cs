//프로그래밍 언어에서 변수는 크게
//1. Box와                => C언어
//2. Post it으로 설명됨   => 파이썬

using System;

int main()
{
    //c언어의 지역변수
    int n1 = 10;
    int n2 = 20;

    n1 = n2;
    n1 = 30;

    n1 = "hello" //error 정수 변수인데 문자열이 할당됨
}

//파이썬 코드
// => 타입을 표기할 필요가 없음
//파이썬의 모든 변수는 reference, 주소를 가르키는 것. heap에 존재함
/*
n1 = 10
n2 = 20

n1 = n2
n1 = 30

n1 = "hello"
*/

//python의 constant full?


CPoint cpt = new CPoint(1, 1);


// 프로그래밍 언어에서 변수는 크게
// 1. "Box" 와                    ==> C언어
// 2. "Post it" 으로 설명 됩니다   ==> Python

int main()
{
    // C언어의 지역변수
    int n1 = 10;
    int n2 = 20;

    n1 = n2;
    n1 = 30;

    n1 = "hello"; // error. 4바이트 정수 보관을 위한 공간에
                  // 문자열 넣을수 없다.
}
// 파이썬 코드
// => 타입을 표기할 필요 없음
n1 = 10;
n2 = 20;

n1 = n2;
n1 = 30;

n1 = "hello";

// C# : value type 은 "Box"
//      reference type 은 "PostIt" 이 됩니다.

CPoint cpt = new CPoint(1, 1);
CPoint cpt1 = cpt;

SPoint spt = new SPoint(1, 1);
SPoint cpt1 = spt;







// 파이썬
n1 = 10;

n1 += 1;