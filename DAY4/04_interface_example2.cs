using static System.Console;

// 핵심 : 사용자 정의 클래스에 크기 비교 함수를 제공하고 싶다면
//	=> 되도록이면 C# 언어의 코딩 규칙을 따르기
//	=> ICompareable 인터페이스 구현

class Label : IComparable
{
	private string title;
	
	public Label(string s) => title = s;

    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }
}

class Program 
{
	public static void Main()
	{
		Label d1 = new Label("GOOD");
		Label d2 = new Label("BAD");


		int ret = d1.CompareTo(d2);

		
	}

	public static void Foo(IComparable ic)
	{
	}
}

