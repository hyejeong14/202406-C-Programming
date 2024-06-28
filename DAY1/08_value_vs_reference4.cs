using static System.Console;

int n1 = 10;
int n2 = n1;

n1 = 20;
WriteLine($"{n1} {n2}");	// 20  10	

int[] x1 = {1, 2, 3};
int[] x2 = x1;

x1[0] = 20;
WriteLine($"{x1[0]} {x2[0]}");	// 20 20

string s1 = "AB";
string s2 = s1;

s1 = "XY"; //new string("XY") 배열과 다르게 새로운 XY라는 String 객체를 만들고 s1이 그 객체를 바라보게 되는 형식으로 s1는 xy, s2는 ab가 됨
WriteLine($"{s1} {s2}");  