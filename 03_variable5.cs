using static System.Console;

// #1. casting
double d = 3.4;
//int n1 = d;	        // error. ����Ÿ �ս� �߻�. 
int n2 = (int)d;    // ok.    ĳ������ C���� ������ ���
                    // is ���� �����ڸ� ����ص� �Ǵµ�, �ڿ� ����..


// #2. nameof
int color = 100;

WriteLine($"color : {color}");
WriteLine($"{nameof(color)} : {color}");

// nameof(color) : "color" �� ��ȯ
// ��, ���� �̸��� "���ڿ�"�� �����ϴ� Ű����

string s = "abcd";
WriteLine($"{nameof(s.Length)} :  {s.Length}"); // "s.Length : 4"

// ����, �Ӽ�(property), Ÿ���̸�� nameof ��밡��.