using static System.Console;

int[] x = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

// �ٽ� : foreach ����

//for : �ݺ� Ƚ���� ����
for (int i = 0; i < 10; i++)
{

}

//foreach 
foreach(int e in x) //x�� ��� ��Ҹ� ���ʴ�� e�� ���
                    //x�� ��ġ���� ���� ������ (enumerable)�� ��� ��ü�� �� �� ����
{
    WriteLine($"{e}, ");
}
WriteLine();

int k = 0;

foreach(int e in k) //k�� enumerable���� �����Ƿ� ����
{

}

//foreach�� ����
// => foreach(int e in obj)�� �� 
// => varit = obj.GetEnumerator()�� ȣ��
// => ����, �ݵ�� obj���� GetEnumerator()�� �־�� ��.

//C# ��� ����
//2���� ���ǹ� : if, switch
//             => switch�� expression ����
//4���� �ݺ��� : while, do~while, for, foreach
