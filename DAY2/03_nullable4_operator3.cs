string s1 = "hello";


object o1 = s1;

//object o1이 가리키던 곳을 string에 담을 때는 캐스팅이 필요하다
string s2 = o1; // object가 항상 string일거라는 보장이 없기 때문에 에러 발생
string s2 = (string)o1; //string 형으로 캐스팅하면 정상 작동

int n1 = o1;  //compile error
int n1 = (int)o1; 	 // o1이 가리키는 것이 int가 아님 (int로 변환 불가)
                     // runtime error (예외 발생)

if (o1 is int)
{
    int n1 = (int)o1;
}

if (o1 is int n2)
{
    //n2 사용
}

//as 연산자 사용
int n3 = (int)o1; //o1이 가리키는 곳이 int로 변환할 수 없다면 예외 발생
int? n4 = o1 as int?; // o1이 가리키는 곳이 int가 아니면 null을 반환
int n5 = o1 as int?; // error 발생

int n6 = (o1 as int?) ?? 0 ;