string s1 = "hello";


object o1 = s1;

//object o1�� ����Ű�� ���� string�� ���� ���� ĳ������ �ʿ��ϴ�
string s2 = o1; // object�� �׻� string�ϰŶ�� ������ ���� ������ ���� �߻�
string s2 = (string)o1; //string ������ ĳ�����ϸ� ���� �۵�

int n1 = o1;  //compile error
int n1 = (int)o1; 	 // o1�� ����Ű�� ���� int�� �ƴ� (int�� ��ȯ �Ұ�)
                     // runtime error (���� �߻�)

if (o1 is int)
{
    int n1 = (int)o1;
}

if (o1 is int n2)
{
    //n2 ���
}

//as ������ ���
int n3 = (int)o1; //o1�� ����Ű�� ���� int�� ��ȯ�� �� ���ٸ� ���� �߻�
int? n4 = o1 as int?; // o1�� ����Ű�� ���� int�� �ƴϸ� null�� ��ȯ
int n5 = o1 as int?; // error �߻�

int n6 = (o1 as int?) ?? 0 ;