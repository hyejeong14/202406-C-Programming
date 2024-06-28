// 36 page ~


//Reference Type 은 null을 허용
//  => 객체(값)이 없음을 나타낼 수 있다.
string s1 = "hello";
string s2 = null;	// ok	


//Value Type은 null을 허용하지 않음
//  => 객체(값)이 없음으 표현할 수 없음
int n1 = 0;
// int n2 = null;	// error

int some_work(int arg)
{
    return 0;    //0이 값 없음을 나타내지는 않는다 단지 약속으로 0, -1 등을 실패로 약속한 것
}


// Nullable<T>를 사용하면 value type에 null로 초기화 가능
// T는 반드시 value type이어야 한다

Nullable<int> n2 = null;
Nullable<int> n3 = 10;

//T? 가 Nullable<T> 에 대한 단축 표기법
int? n4 = null; //Nullable<int> n4 = null; r과 같음
  

