
// 아래 코드는 "T" 는 반드시 value type 이어야 한다는 의미 입니다.
class List<T> where T : struct
{
}

class Program
{
    public static void Main()
    {
        List<int> c1 = new List<int>(); // ok
                                        // List<string> c2 = new List<string>(); // error
                                        // string 은 value 타입아님, 참조타입!
                                     
    }
}


class C1<T> where T : struct { }
class C2<T> where T : class { }
class C3<T> where T : class? { }
class C4<T> where T : notnull { }
class C5<T> where T : unmanaged { }
class C6<T> where T : new() { }    //디폴트 생성자가 있어야한다
class C7<T> where T : base_class_name { } // base_class_name 에서
                                          // 파생 되어야 한다.

class C8<T> where T : interface_name { }  //interface_name 구현해야 한다


// 2개 이상 표기 가능합니다.
class C11<T> where T : class, IComparable
{
}

class C12<T, U> where T : struct
                where U : class
{
}