// 33 page ~ 
using static System.Console;

//�迭 : ���� Ÿ���� ��ü�� ������ ����
int[] array = {1, 2, 3};


//Tuble : �ٸ� Ÿ���� ��ü�� ���� �� ������ �� ���

// C#�� Tuple
// Tuple : .net 4.0�� ��� -> Reference Type, immutable
// ValueTuple : .net 4.7�� ��� -> Value Type, mutable  <== ����
Tuple<int, double, string> t1 = 
			new Tuple<int, double, string>(1, 3.4, "AA");

WriteLine($"{t1.Item1}"); // 1
WriteLine($"{t1.Item2}"); // 3.4
WriteLine($"{t1.Item3}"); // "AA"


