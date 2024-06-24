int n1;		// 초기화 안됨.

// 변수의 초기값을 지정하는 방법.
int n2 = 0;
int n3 = new int();

//C# 언어의 모든 타입은 default value의 개념을 가지고 있음
//int의 디폴트 값(0)으로 초기화
int n4 = default(int);
//좌변 타입의 디폴트값으로 초기화
int n5 = default;

//var 타입의 경우 타입을 알 수 없으므로 에러
var n6 = default;
//int의 디폴트값으로 초기화
var n7 = default(int);


// default 방식은 generic에서 유용하게 활용
void goo<T>(T n)
{
    //T a = 초기값; //초기값 자리에 default를 사용
}

