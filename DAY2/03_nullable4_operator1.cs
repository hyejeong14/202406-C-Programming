using static System.Console;

int? n1 = null;

// int a = n1;  // error
// int a = (int)n1;  // ok. ������ n1 == null �̸� ����

// int a = n1.GetValueOfDefault(3); // ok. ���ܵ� ����

// �ٽ� ?? ������. �Ʒ� �ڵ�� ���ڵ�� �����մϴ�.
int a = n1 ?? 3;

WriteLine($"{a}");

