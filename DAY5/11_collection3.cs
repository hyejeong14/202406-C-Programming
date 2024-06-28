using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;
// 컬렉션(Collection) : 동일타입의 객체를 여러개 보관하는 도구
//                    "컨테이너"라고도 합니다.

// 주제 3. 배열 - 연속된 메모리, size 변경이 안됨

class Program
{
    public static void Main()
    {
        int[] arr1 = { 1, 2, 3, 4, 5 }; // 이 코드는 아래 처럼 변경됩니다.

        var arr2 = Array.CreateInstance(typeof(int), 5);

        Type t1 = arr1.GetType();
        Type t2 = arr2.GetType();

        WriteLine(t1.Name);
        WriteLine(t2.Name);

        // -----------------------
        var arr3 = arr1;

        Array.Resize(ref arr1, 20); // arr1을 20개 크기로 변경 
                                    // 기존 array를 복사한 새로운 array 생성

        WriteLine(arr1.Length); // 20  


        arr1[0] = 10;

        WriteLine(arr1[0]); // 10
        WriteLine(arr3[0]); // 1

    }
}