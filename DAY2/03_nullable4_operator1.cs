using static System.Console;

int? n1 = null;

// int a = n1;  // error
// int a = (int)n1;  // ok. 하지만 n1 == null 이면 예외

// int a = n1.GetValueOfDefault(3); // ok. 예외도 없음

// 핵심 ?? 연산자. 아래 코드는 위코드와 동일합니다.
int a = n1 ?? 3;

WriteLine($"{a}");

