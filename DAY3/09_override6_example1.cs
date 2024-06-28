class Shape
{
	private int color = 0;

	public void SetColor(int c) { color = c; }

	public virtual void Draw() { }
}

class Rect : Shape
{
	public override void Draw() { }
}

class Program 
{
	public static void Main()
	{
		Shape s = new Rect();
		s.Draw();
	}
}