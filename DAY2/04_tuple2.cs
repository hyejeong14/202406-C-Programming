using static System.Console;

// Tuple 을 생성하는 다양한 방법
Tuple<int, int, int> t1 = new Tuple<int, int, int>(1,2,3);
Tuple<int, int, int> t2 = Tuple.Create(1, 2, 3);

// 아래와 같이 var를 이용하면 편리하게 사용 가능
var t3 = new Tuple<int, int, int>(1,2,3);

//아래와 같은 방법이 가장 편리한 방법
var t4 = Tuple.Create(1, 2, 3);


// Tuple은 Immutable한 객체
//t4.Item1 = 10; //error immutable하므로 변경 불가
int n = t4.Item1; // 읽는 것은 가능

// 8개까지만 저장 가능함
// var t5 = Tuple.Create(1,2,3,4,5,6,7,8,9); error 
var t5 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);

// 8번째 요소에 대한 접근 방법이 다름
WriteLine($"{t5.Item1}"); // 1
WriteLine($"{t5.Item7}"); // 7
WriteLine($"{t5.Rest}"); // (8)
WriteLine($"{t5.Rest.Item1}"); // 8


//8개 이상 사용하려면 nested 구조로 사용하기
var t6 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8,9,10));

WriteLine($"{t6.Rest.Item1}"); // (8,9,10)
WriteLine($"{t6.Rest.Item1.Item1}"); // 8
WriteLine($"{t6.Rest.Item1.Item2}"); // 9

