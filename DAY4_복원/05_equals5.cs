using static System.Console;

class Program 
{
	public static void Main()
	{
		string s = "ABCD";
		string s1 = "ABCD";
        //String�� ���� �Ұ����� ��ü��
        //���� s1�� s�� ���� ��ü�� ������ (�����Ǵ� ��ü�� ���Ե� �� -> ���� Ǯ)
        //String�� ��� s,s1 ���� �����Ǹ� ����Ǯ���� ���������� �Ʒ� s2ó�� �����Ǹ� ���ο� ��ü�� ������.
        //String ���� �ǵ��� s2���� s1ó�� �����ϴ� �� ����(�޸� ���� ���̱�)


		string s2 = new string("ABCD");

		
        //s�� s1�� ���� ��ü
        WriteLine($"a == b      : {s == s1}");
        WriteLine($"a.Equals(b) : {s.Equals(s1)}");
        WriteLine($"object.ReferenceEquals(a, b) : {object.ReferenceEquals(s, s1)}");

        //s�� s2�� �ٸ� ��ü���� ���´� ������
        WriteLine($"a == b      : {s == s2}"); //���� ==�� ��ü�� ���ϼ��� �����ϴ� ������ ������ ==�� �����ǵǾ� true�� ��ȯ�ȴ�.
        WriteLine($"a.Equals(b) : {s.Equals(s2)}"); //���� ���� (true)
        WriteLine($"object.ReferenceEquals(a, b) : {object.ReferenceEquals(s, s2)}"); // ��ü�� �������� �����ϴ� �޼ҵ�
    }
}