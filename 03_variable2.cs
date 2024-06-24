using static System.Console;

// 초기화되지 않은 변수의 특징
// 쓰기는 가능하지만 읽기는 불가능
int n;
int a = 0;

a = n;			//초기화 되지 않았을 때 읽으려고하면 에러가 발생
n = a;          //읽기는 가능
a = n;          //n이 a의 값으로 초기화 되었으므로 읽기 가능
WriteLine(n);	

