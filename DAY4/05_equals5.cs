using static System.Console;

class Program 
{
	public static void Main()
	{
		string s = "ABCD";
		string s1 = "ABCD";
		string s2 = new string("ABCD");

		
        WriteLine($"a == b      : {s == s1}");
        WriteLine($"a.Equals(b) : {s.Equals(s1)}");
        WriteLine($"object.ReferenceEquals(a, b) : {object.ReferenceEquals(s, s1)}");


        WriteLine($"a == b      : {s == s2}");
        WriteLine($"a.Equals(b) : {s.Equals(s2)}");
        WriteLine($"object.ReferenceEquals(a, b) : {object.ReferenceEquals(s, s2)}");
    }
}