using static System.Console;

// int 와 int? 사이의 변환, 비교등.. 
int a1 = 10; // a1 은 "int 한개"
int? n1 = 10; // n1 은 "int 한개 + bool 한개"


int? n2 = a1; // ok      int? 에 int 를 바로 담을수 있다.
int a2 = n1; // error.  int  에 int? 를 직접 담을수는 없습니다.


int a3 = (int)n1;   // ok. 단, n1 이 값이 있어야 합니다.
                    // n1 이 null 이면 예외 발생. 




