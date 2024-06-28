using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

// 주제 7. Dictionary - key 값을 가지고 value 를 보관하는 collection
// 1. 정렬되지 않은 Dictionary
//      해쉬 기반  : Dictionay<K,V>, HashTable
//      리스트기반 : ListDictionary : Single Linked List
//                   OrderedDictionary : HashTable + ArrayList
//                                      ( 검색)      (키값만 따로보관)
//                                                  인덱스사용가능(dic[0])

// 2. 정렬된 Dictionary
// SortedDictionary : RedBlack Tree
// SortedList  : 배열 2개    List<Key> k =new List<Key>
//                           List<Value> v = new List<Value>

class Program
{
    public static void Main()
    {
        
        // KeyValuePair 를 보관하는 hash table
        Dictionary<string, string> dic = new Dictionary<string, string>();

        dic.Add("mon", "월요일");


        WriteLine(dic["mon"]);




    }
}