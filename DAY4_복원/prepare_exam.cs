using static System.Console;
// i++ : 출력 후 더하기
// ++i : 더하고 출력하기

//foreach 구문은 열거 가능(enumerable)한 객체만 가능하다 
//이유 : foreach(int e in obj)일 때, var it = obj.GetEnumerator()를 호출
// 따라서 반드시 obj에는 GetEnumerator()가 있어야 함.
int[] x = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

foreach (int e in x)
{
    WriteLine();
    WriteLine("foreach 예제");
    WriteLine(e);
    WriteLine("---------------------------");
}

//switch 문 사용시 fallthrough 기법을 사용하고 싶다면 break를 빼고 goto case(next number)를 작성하면 된다
