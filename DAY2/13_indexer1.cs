using static System.Console;

class Sentence
{
    private string[] words;

    public Sentence(string s) 
	{ 
		words = s.Split(); 
	}	
}

class Program
{
    public static void Main()
    {
        Sentence s = new Sentence("Dog is Animal");

        WriteLine( s.Text );  // Dog is Animal

//      WriteLine( s[2] ); 	// Animal

//      s[0] = "Cat";

//      WriteLine(s.Text);  // Cat is Animal
    }
}
