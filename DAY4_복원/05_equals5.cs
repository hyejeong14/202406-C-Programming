using static System.Console;

class Program 
{
	public static void Main()
	{
		string s = "ABCD";
		string s1 = "ABCD";
        //String은 변경 불가능한 객체임
        //따라서 s1은 s와 같은 객체를 공유함 (공유되는 객체가 포함된 곳 -> 인턴 풀)
        //String의 경우 s,s1 같이 생성되면 인턴풀에서 공유되지만 아래 s2처럼 생성되면 새로운 객체가 생성됨.
        //String 사용시 되도록 s2보단 s1처럼 생성하는 걸 권장(메모리 부하 줄이기)


		string s2 = new string("ABCD");

		
        //s와 s1은 동일 객체
        WriteLine($"a == b      : {s == s1}");
        WriteLine($"a.Equals(b) : {s.Equals(s1)}");
        WriteLine($"object.ReferenceEquals(a, b) : {object.ReferenceEquals(s, s1)}");

        //s와 s2는 다른 객체지만 상태는 동일함
        WriteLine($"a == b      : {s == s2}"); //원래 ==은 객체의 동일성을 조사하는 연산자 이지만 ==가 재정의되어 true가 반환된다.
        WriteLine($"a.Equals(b) : {s.Equals(s2)}"); //상태 조사 (true)
        WriteLine($"object.ReferenceEquals(a, b) : {object.ReferenceEquals(s, s2)}"); // 객체의 동질성을 조사하는 메소드
    }
}