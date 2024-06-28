using static System.Console;

// #1. construction
int a = 1, b = 2, c = 3;

var t1 = (a, b, c);


// #2. deconstruction




// #3. 아래 2줄의 차이점을 잘 생각해 보세요.
(int a1, int a2, int a3) t2 = (1, 2, 3);
(int b1, int b2, int b3)    = (4, 5, 6);

