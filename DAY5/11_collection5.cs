using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

// 주제 4. LinkedList
// 삽입 삭제가 빠르다.
// 인덱스를 사용해서 접근 할수 없다. -열거자로 사용

class Program
{
    public static void Main()
    {
        LinkedList<int> st = new LinkedList<int>();
        st.AddFirst(10);
        st.AddLast(20);

        st[0] = 10; // error. [] 연산 사용할수 없음. 연속되지 않은 메모리를 사용하는 배열은 [] 연산을 제공하지 않는다.
    }
}


