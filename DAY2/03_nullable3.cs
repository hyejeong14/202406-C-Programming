using static System.Console;

// int �� int? ������ ��ȯ, �񱳵�.. 
int a1 = 10; // a1 �� "int �Ѱ�"
int? n1 = 10; // n1 �� "int �Ѱ� + bool �Ѱ�"


int? n2 = a1; // ok      int? �� int �� �ٷ� ������ �ִ�.
int a2 = n1; // error.  int  �� int? �� ���� �������� �����ϴ�.


int a3 = (int)n1;   // ok. ��, n1 �� ���� �־�� �մϴ�.
                    // n1 �� null �̸� ���� �߻�. 




