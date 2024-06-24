using static System.Console;

int a = 10;
int b = 20;

// 변수의 값을 출력하는 방법.

// 방법 #1. 변수 한개만 출력 할때는 아래 처럼
WriteLine(a);

// 방법 #2. formatting 01
WriteLine("a = {0}, b = {1}", a, b);


// 방법 #3. formatting 02 ($문자열)
WriteLine($"a = {a}, b = {b}");
