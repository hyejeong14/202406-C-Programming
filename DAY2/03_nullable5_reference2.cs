// ���α׷����� "name" �� �׻� ��ȿ�� ���� ������ �Ѵ�.
// => ���α׷��� ��𿡼��� "name" �� null �� �������� �ȵȴ�.
string name = "kim";

Console.WriteLine(name);

name = null // C# 8.0 ������ ������ �ƴ�. ��� ����
            // C# 9.0���� �ش� �ڵ�� null �� �� �� ����
            // ���� �ڵ���� ȣȯ���� ����� ������ �ƴ����� ���� ó��

string s1 = null; // ���, null�� ����� �� ���� reference
string s2 = null; // Ok, null�� �� �� �ִ� reference
                  // ��, �� �ڵ�� C# 8.0���� ����

