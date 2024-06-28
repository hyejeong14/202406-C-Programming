// 23 page ~
using System;

//C# : 모든 타입은 C# 언어가 정의하지 않고 CLR에 의해 정의된다. (CTS)
//     모든 타입은 Struct 아니면 class로 설계되었다.
//CLR : IL언어를 해석하는 것
//       C#
//       ↓
//       IL
//       ↓
//       CLR

//CLR에서 32bit 정수는 int32라는 struct로 정의되었음

/*struct Int32{
    //멤버 데이터와
    //다양한 멤버 함수(메소드)
}*/

//C#의 Int는 CLR에서 정의한 Int32 구조체에 대한 alias

//아래 세줄은 동일
int             n1 = 0;
System.Int32    n2 = 0;
Int32           n3 = 0;


//아래 세줄 역시 동일
double          d1 = 0;
System.Double   d2 = 0;
Double          d3 = 0;


//아래 세줄 역시 동일
string          s1 = 'A';
System.String   s2 = 'A';
String          s3 = 'A';

int n1 = 0;


double d1 = 0;


string s1 = "A";
