using static System.Console;

int[] x = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

// 핵심 : foreach 구문

//for : 반복 횟수를 지정
for (int i = 0; i < 10; i++)
{

}

//foreach 
foreach(int e in x) //x의 모든 요소를 차례대로 e에 담기
                    //x의 위치에는 열거 가능한 (enumerable)한 모든 객체가 올 수 있음
{
    WriteLine($"{e}, ");
}
WriteLine();

int k = 0;

foreach(int e in k) //k는 enumerable하지 않으므로 에러
{

}

//foreach의 원리
// => foreach(int e in obj)일 때 
// => varit = obj.GetEnumerator()를 호출
// => 따라서, 반드시 obj에는 GetEnumerator()가 있어야 함.

//C# 제어문 정리
//2개의 조건문 : if, switch
//             => switch는 expression 가능
//4개의 반복문 : while, do~while, for, foreach
