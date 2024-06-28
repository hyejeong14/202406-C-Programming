//reference type은 항상 null을 허용한다
string s1 = "hello";
string s2 = null;


// null을 사용하는 것은 예외 발생 위험이 있음
var ret1 = s1.Length; //5
var ret2 = s2.Length; //예외


//value type은 null을 허용할지 사용자가 선택할 수 있음
int  n1 = 10;
int? n2 = null; //? 기호를 사용하여 null 허용으로 변경


// 회원의 나이 정보를 다룰 때 ( int vs int? ) 어떤 것이 더 안전한가?
//     => 일반적으로 나이 정보는 null값이 있을 수 없다
//     => 이 경우 int?로 만들면 실수로 null을 가질 수 있게 되고 안전하지 않은 코드가 됨.
//     => 항상 변수는 유효한 값을 가지는 것이 안전함
//     => 즉, 반드시 필요하지 않다면 int?를 사용하지 말고 int를 사용하는 것을 권장


// 이름 정보 역시 항상 유효한 값을 가져야함 
string s3 = null;


