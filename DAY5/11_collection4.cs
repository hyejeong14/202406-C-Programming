using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

// 주제 3. 동적 배열 - ArrayList, List<T> 
//         크기를 변경할수 있는 배열. 
//         연속된 메모리,  배열크기 변경가능.

// 검색 빠르다. 인덱스로 접근 가능.
// 삽입삭제 느리다.
class Program
{
    public static void Main()
    {
        ArrayList arr1 = new ArrayList(); // C#1.0
      
        // C#2.0
        List<int> arr2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        WriteLine(arr2.Count); // 10개 

        arr2.Add(20);
        WriteLine(arr2.Count); // 11개

        //-----------------------------------
        // Capacity 개념
        List<int> arr3 = new List<int>();

        arr3.Add(10);
        WriteLine(arr2.Count);    // 1
        WriteLine(arr2.Capacity); // 4

        arr3.Add(20); // 이미 캐패시터가 있다. 빠르다.!
        WriteLine(arr2.Count);    // 2
        WriteLine(arr2.Capacity); // 4

        arr3.Add(30);
        arr3.Add(40);
        arr3.Add(50);  // 메모리 재할당 필요. 느리다.
        WriteLine(arr2.Count);    // 5
        WriteLine(arr2.Capacity); // 8

        arr2.TrimExcess(); // 여분의 메모리 제거

        WriteLine(arr2.Count);    // 5
        WriteLine(arr2.Capacity); // 5


    }
}





