using System;

Console.Write("press any key >> ");

int n = Console.Read();    // �Է� ���ۿ��� ������
                           // �Է� ���۰� ��� �ִٸ�
                           // "Ű����-> �Է¹���"�� ���� ��ƾ�� ����
                           // ��, enter�� ������ ������ ���

//�Է� ���۰� �ƴ� "Ű����κ��� ���� ������"
//  => enter �ʿ���� �ƹ�Ű�� ������ ��� ��ȯ
Console.Write("press any key (ReadKey) >> ");
//ConsoleKeyInfo cki = Console.ReadKey();
//  => �Էµ� ���ڰ� echo��
ConsoleKeyInfo cki = Console.ReadKey(true); //�Էµ� ���ڰ� echo���� ����
Console.WriteLine(cki.KeyChar);

