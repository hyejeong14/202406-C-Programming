using System;
using System.Collections.Generic;       
// Enumerator

class Program
{
    public static void Main()
    {
        LinkedList<int> s = new LinkedList<int>();

        s.AddFirst(10);
        s.AddFirst(20);
        s.AddFirst(30);
        s.AddFirst(40);

        // 열거자(enumerator)
        // => 다른 언어의 반복자(iterator) 
        // => 컬렉션의 종류에 상관없이 동일한 방식으로 열거 하기 위한 객체.  

        var it = s.GetEnumerator();

        // 주의. MoveNext()를 한번 호출해야 처음을 가리킨다.
        while( it.MoveNext() )
        {
            Console.WriteLine(it.Current); // it 가 가리키는 요소의
                                           // 값을 얻기
        }
    }


}
