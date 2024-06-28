using static System.Console;

// #1. Tuple vs ValueTuple
// Tuple      : reference type, immutable
// ValueTuple : value type,     mutable

Tuple<int, int, int> t1 = new Tuple<int, int, int>(1, 2, 3);



// #2. ValueTuple 생성
ValueTuple<int, int, int> vt1 = new ValueTuple<int, int, int>(1, 2, 3);
ValueTuple<int, int, int> vt2 = ValueTuple.Create(1, 2, 3);
ValueTuple<int, int, int> vt3 = (1, 2, 3);
(int, int, int) vt4 = (1, 2, 3);
var vt5 = (1, 2, 3);



// #3. 주의
var a = (1);		
var b = (1, 2);		

// #4. 요소 접근
var vt6 = (1, 2, 3);


// #4. Named Member
(int, int, int)       vt7 = (1,2,3); // unnamed tuple


