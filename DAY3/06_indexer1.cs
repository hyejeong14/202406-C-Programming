/*using static System.Console;

//Sentence : ������ �ܾ�� ����/���� �� �� �ִ� Ŭ����

class Sentence
{
    //�Ʒ� �ʵ�� ���� �迭 ��ü�� ������ �ʰ�, ���� reference�� ����
    //  => �ش� �迭�� �ܺο��� ������ �ʿ䰡 ���� ������ private�� �ʵ� ���� (property �ʿ����)
    private string[] words;
    //private string[] words = new string[3]; // �̷��� �ؾ� �迭�� ������ ��

    public Sentence(string s) 
	{ 
		words = s.Split(); //{"Dog","is","Animal"}
	}	

    //Indexer(�ε���) : ��ü�� �迭ó�� ����ϰ� ���� �� ���
    //property�� ������ ����ε�, �̸� ��ġ�� this[]fh vyrl
    //public string Name; //property
    public string this[int index] //indexer
    {
        get => words[index];
        set => words[index] = value; //������ property�� �����ϰ� ���
    }

    //Text �Ӽ� �����
    public string Text
    {
        get => string.Join(" ".words); //�迭 ���� ��ġ��
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

// Sentence : ������ �ܾ�� ����/���� �Ҽ� �ִ� Ŭ����
class Sentence
{
    // �Ʒ� �ʵ�� ���� �迭 ��ü�� ������ �ʰ�, ���� reference�� �ֽ��ϴ�.
    // => ���� �� �迭�� �ܺο����� ������ �ʿ䰡 ���� �����ϴ�.
    // => ������Ƽ�� ����� �ʿ� �����ϴ�. �׷��� private �ʵ�.. 
    private string[] words;
    //  private string[] words = new string[3]; // �̷��� �ؾ� �迭 �����Ѱ�

    public Sentence(string s)
    {
        // s.Split() : s ���ڿ��� �ܾ�� �и��ؼ� �迭 ����
        //             
        words = s.Split();  // words = new string[] {"Dog", "is", "Animal"}
    }

    // �ε���(indexer) : ��ü�� �迭ó�� ����ϰ� ������ ���
    // property �� ������ ����ε�, 
    // "�̸�" ��ġ�� "this[]" �� ǥ��

    //  public string Name            // property
    public string this[int index] // indexer
    {
        get => words[index];
        set => words[index] = value;    // ������ property �� ����
    }

    // �迭�� �ִ� ���ڿ� ��ġ�¹�
    // string s = string.Join(" ", words)

    // Text �Ӽ� ����� ������
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

