/*using static System.Console;

//Sentence : 문장을 단어별로 관리/접근 할 수 있는 클래스

class Sentence
{
    //아래 필드는 아직 배열 객체는 만들지 않고, 단지 reference만 있음
    //  => 해당 배열은 외부에서 접근할 필요가 없기 때문에 private로 필드 생성 (property 필요없음)
    private string[] words;
    //private string[] words = new string[3]; // 이렇게 해야 배열을 생성한 것

    public Sentence(string s) 
	{ 
		words = s.Split(); //{"Dog","is","Animal"}
	}	

    //Indexer(인덱서) : 객체를 배열처럼 사용하고 싶을 때 사용
    //property와 동일한 모양인데, 이름 위치에 this[]fh vyrl
    //public string Name; //property
    public string this[int index] //indexer
    {
        get => words[index];
        set => words[index] = value; //구현은 property와 동일하게 사용
    }

    //Text 속성 만들기
    public string Text
    {
        get => string.Join(" ".words); //배열 문자 합치기
    }
}

class Program
{
    public static void Main()
    {
        Sentence s = new Sentence("Dog is Animal");

        WriteLine(s.Text);  // Dog is Animal

        WriteLine( s[2] ); 	// Animal

        s[0] = "Cat";

        WriteLine(s.Text);  // Cat is Animal
    }
}*/

using static System.Console;

// Sentence : 문장을 단어별로 관리/접근 할수 있는 클래스
class Sentence
{
    // 아래 필드는 아직 배열 객체는 만들지 않고, 단지 reference만 있습니다.
    // => 또한 이 배열은 외부에서는 접근할 필요가 전혀 없습니다.
    // => 프라퍼티를 사용할 필요 없습니다. 그래서 private 필드.. 
    private string[] words;
    //  private string[] words = new string[3]; // 이렇게 해야 배열 생성한것

    public Sentence(string s)
    {
        // s.Split() : s 문자열을 단어별로 분리해서 배열 생성
        //             
        words = s.Split();  // words = new string[] {"Dog", "is", "Animal"}
    }

    // 인덱서(indexer) : 객체를 배열처럼 사용하고 싶을때 사용
    // property 와 동일한 모양인데, 
    // "이름" 위치에 "this[]" 로 표기

    //  public string Name            // property
    public string this[int index] // indexer
    {
        get => words[index];
        set => words[index] = value;    // 구현은 property 와 동일
    }

    // 배열에 있는 문자열 합치는법
    // string s = string.Join(" ", words)

    // Text 속성 만들어 보세요
    public string Text
    {
        get => string.Join(" ", words);
    }
}

class Program
{
    public static void Main()
    {
        Sentence s = new Sentence("Dog is Animal");

        WriteLine(s[2]); 	// Animal

        s[0] = "Cat";

        WriteLine(s.Text);  // Cat is Animal
    }
}

