using System;
using static System.Console;

struct Temperature : IComparable, IComparable<Temperature>, IEquatable<Temperature>
{
    private double Value { set; get; } = 0;

    public Temperature(double val) => Value = val;

    public int CompareTo(object? obj)
    {
        if (obj == null) return 1;

        if ( obj is Temperature other)
            return Value.CompareTo(other.Value);
        else
           throw new ArgumentException("Object is not a Temperature");      
    }

    public int CompareTo(Temperature other)
    {
        return Value.CompareTo(other.Value);
    }

	public override bool Equals(object? obj)
	{
		if ( obj == null || !(obj is Temperature) )
		 	return false;

		Temperature other = (Temperature)obj;	

    	return (int)Value == (int)(other.Value);
	}	

	public override int GetHashCode() 
		=> Value.GetHashCode();


	public bool Equals(Temperature other)
	{
    	return (int)Value == (int)(other.Value);
	}
}

class Program
{
    public static void Main()
    {
        Temperature t1 = new Temperature(5.5);
        Temperature t2 = new Temperature(5.3);
		object o = t2;

        Console.WriteLine($"{t1.CompareTo(t2)}");
		Console.WriteLine($"{t1.CompareTo(o)}");
		Console.WriteLine($"{t1.Equals(t2)}");
		Console.WriteLine($"{t1.Equals(o)}");
		
    }
}


