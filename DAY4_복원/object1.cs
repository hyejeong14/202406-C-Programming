// object1.cs
using System.Drawing;

// C# 의 대부분의 클래스는 Object 에서 파생됩니다.
class Object
{
    // 이 안에 있는 특징(기능)은 모든 타입이 물려 받게 됩니다.

    // 객체를 문자열로 반환하는 기능은 디버깅시에 아주 좋습니다.
    public virtual string? ToString()
    {
        // 기본 구현은 객체의 타입 반환.
    }
}

class Rectange // : Object
{
    // ToString() 을 override 해서 자신이 가진 필드를 보기좋게 문자열로 반환
}

class Point // : Object
{
    // ToString() 을 override 해서 자신이 가진 필드를 보기좋게 문자열로 반환
}

class Int32[]
{
    // ToString override 하지 않음.
}

// 사용자 정의 타입
class Person
{
    public string Name { get; set; };
    public int Age { get; set; };

    // ToString() 을 override 해서 "Name, Age" 를 가지고 문자열로
    // 반환하는 것이 좋습니다.
}

class Program
{
    public static void Main()
    {
        // 이미 C# 언어에 "Rectangle", "Point" 가 있습니다.
        // => using System.Drawing; 가 필요

        Rectangle r = new Rectangle(1, 1, 1, 1);

        Point p = new Point(1, 1);


        // 개발을 하다 보면 변수값(객체의 속성)을 화면 출력하고
        // 싶을때가 있습니다.
        // => C#, Java 에서는 이럴때 모든 객체가 가진 ToString() 을 호출하면됩니다
        // => Java : toString()

        Console.WriteLine(r.ToString());
        Console.WriteLine(p.ToString());


        int[] arr = { 1, 2, 3 };

        Console.WriteLine(arr.ToString()); // 1. int[]    - C#
                                           // 2. {1,2,3}  - Java, swift 
    }
}