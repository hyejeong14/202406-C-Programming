
// �Ʒ� �ڵ�� "T" �� �ݵ�� value type �̾�� �Ѵٴ� �ǹ� �Դϴ�.
class List<T> where T : struct
{
}

class Program
{
    public static void Main()
    {
        List<int> c1 = new List<int>(); // ok
                                        // List<string> c2 = new List<string>(); // error
                                        // string �� value Ÿ�Ծƴ�, ����Ÿ��!
                                     
    }
}


class C1<T> where T : struct { }
class C2<T> where T : class { }
class C3<T> where T : class? { }
class C4<T> where T : notnull { }
class C5<T> where T : unmanaged { }
class C6<T> where T : new() { }    //����Ʈ �����ڰ� �־���Ѵ�
class C7<T> where T : base_class_name { } // base_class_name ����
                                          // �Ļ� �Ǿ�� �Ѵ�.

class C8<T> where T : interface_name { }  //interface_name �����ؾ� �Ѵ�


// 2�� �̻� ǥ�� �����մϴ�.
class C11<T> where T : class, IComparable
{
}

class C12<T, U> where T : struct
                where U : class
{
}