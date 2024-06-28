class Program
{
    //인자로 int만 가능
    public static void M1(int n) { }

    //object는 타입 대부분의 기반 클래스
    //  => 모든 객체는 object로 가리킬 수 있음

    public static void M2(object n) { }
    public static void Main()
    {
        M1(10);
        M1("ABCD");

        M2(10);
        M2("ABCD");

        //어떠한 타입을 몇 개라도 보낼 수 있는 메소드
        MyWriteLine(10, 3.4, "ABC");

    }
    public static void MyWriteLine(params object[] arr)
    {
        foreach(object o in arr) {
            //모든 타입은 oject에서 파생되는데, object에는 ToString() 이 있음
            // 즉, 모든 객체는 ToString()이 있다
            string s = o.ToString();

            //문자열을 출력하는 내부함수로 s를 출력
            Console.WriteLine(s); // C# 내부 함수라고 가정
    }