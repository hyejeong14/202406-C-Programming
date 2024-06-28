using static System.Console;

string s = "ABCD";

int[] arr = { 1, 2, 3, 4, 5 };

// C#은 객체의 다양한 정보를 얻고 싶을 때 메소드가 아닌 속성을 사용하는 경우가 많음
WriteLine(s.Length); // s.GetLength() 같은 메소드가 아님


// 속성이 아닌 메소드를 사용하는 경우는
// 단순히 정보를 얻는 것이 아니라 연산이 필요하거나, 정보를 얻을 때 인자가 필요한 경우
WriteLine(arr.Length);
WriteLine(arr.GetLength(0));

