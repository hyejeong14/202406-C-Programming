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

s1 = "XY"; //new string("XY") �迭�� �ٸ��� ���ο� XY��� String ��ü�� ����� s1�� �� ��ü�� �ٶ󺸰� �Ǵ� �������� s1�� xy, s2�� ab�� ��
WriteLine($"{s1} {s2}");  