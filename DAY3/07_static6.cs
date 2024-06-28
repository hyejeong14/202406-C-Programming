// 07_static6.cs
class Example
{
    public static void M1() { }
    public void M2() { }
}

class Program
{
    public static void Main()
    {
        // #1. static method 는 객체없이 클래스 이름으로 호출
        Example.M1();

        // #2. instance method 는 반드시 객체 필요
        Example e = new Example();
        e.M2(); // 반드시 객체 e가 있어야 합니다.


        // #3. C# 프로그램의 entry
        // => "Main 이라는 static method" 
        // => static method 이므로 이 Main 이 수행될때는
        //    "Program" 클래스의 객체가 생성된것이 아닙니다.

        // #4. 단순히 메소드 문법을 설명할 것인데,
        // => NoModifier1 처럼 instance method로 하면은
        NoModifier1(3); // error.  이렇게 사용할수 없고

        Program p = new Program();
        p.NoModifier1(3); // ok.  이렇게 했어야 합니다.

        // 하지만 NoModifier2 처럼 static method라면 아래처럼
        // 바로 호출가능합니다.
        // => static method 에서는 static 만 접근 가능
        NoModifier2(3);
    }

    public void NoModifier1(int n) { }
    public static void NoModifier2(int n) { }
}