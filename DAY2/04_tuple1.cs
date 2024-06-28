// 33 page ~ 
using static System.Console;

//배열 : 같은 타입의 객체를 여러개 보관
int[] array = {1, 2, 3};


//Tuble : 다른 타입의 객체를 여러 개 보관할 때 사용

// C#의 Tuple
// Tuple : .net 4.0에 출시 -> Reference Type, immutable
// ValueTuple : .net 4.7에 출시 -> Value Type, mutable  <== 권장
Tuple<int, double, string> t1 = 
			new Tuple<int, double, string>(1, 3.4, "AA");

WriteLine($"{t1.Item1}"); // 1
WriteLine($"{t1.Item2}"); // 3.4
WriteLine($"{t1.Item3}"); // "AA"


