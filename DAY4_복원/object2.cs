using System.Reflection;

class Program
{
    public static void Main()
    {
        string s = "hello";

        object obj = s;

        // obj 가 가리키는 객체의 타입을 알고 싶다.!!
        // 방법 #1. is 연산자

        bool b = obj is string; // if ( obj is string )


        // 방법 #2. reflection 
        // => object 클래스가 제공하는 7개 메소드 중에 "GetType()" 사용

        Type t = obj.GetType(); // obj 가 가리키는 타입에 대한 정보를 담은
                                // Type 객체 반환

        Console.WriteLine(t.Name);
        Console.WriteLine(t.BaseType?.Name);

        Console.WriteLine(t.FullName);
        Console.WriteLine(t.BaseType?.FullName);

        //타입의 정보를 알아내는 것을 Reflection이라고 한다
        var methods = t.GetMethods();
        Console.WriteLine(methods);

        foreach (MethodInfo mi in methods)
        {
            Console.WriteLine($"Name : {mi.Name}, ReturnParameter : {mi.ReturnParameter}, ReturnType : {mi.ReturnType}");
        }

        var fields = t.GetFields(); //public 필드만 구할 수 있음. private 필드는 접근하지 못함

        foreach (FieldInfo fi in fields)
        {
            Console.WriteLine($"{fi.Name}");
        }
    }
}