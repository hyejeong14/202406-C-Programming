using System;
using System.Text;
using static System.Console;

//String은 Immutable
string s = "AB";
//s[0] = 'X'; //error

//string의 메소드 중에서 "변경"하는 메소드는 없음

string s1 = s.ToLower(); //문자열을 소문자로 변경
//ToLower은 변경하는 메소드가 아닌가?
//      => ToLower은 해당 객체를 가지고서 새로운 객체를 생성해서 반환. 기존 객체를 변경하지 않음

//mutable한 string 이 필요하다면 StringBuiler를 사용
StringBuilder sb = new StringBuilder("ABCD");

sb[0] = 'X'; // 가능! 

WriteLine(sb);

//문자열 변경에 관련된 많은 메소드가 존재 sb. 으로 확인
sb.Append("KKK");

WriteLine(sb);

//StringBuilder 사용시 주의사항 : new 로만 생성가능
//StrignBuilder sb1 = "ABC"; 형식 지원 불가
//immutable이 빠르고 안전하기 때문에 변경 필요가 없을 경우에는 String 을 권장
//mutable 형식은 고려 사항이 많기 때문


//  C/C++/JAVA/C#
//  => 기본이 mutable
//  => 단, String 등의 성능에 중요한 영향을 미치는 경우 타입 자체를 immutable 하게 제공

//  Rust, Haskell 등의 함수형 언어
//  => 모든 타입은 기본이 immutable
//  => 변경 가능하려면 mut 사용
// n : int = 10;
// n : mut int = 10;