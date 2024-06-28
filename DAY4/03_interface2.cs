using static System.Console;

class Camera
{
    public void Take() => WriteLine("Take a picture");
}

class People
{
    public void Use(Camera c) => c.Take();
}

class Program
{
    public static void Main()
    {
        People p = new People();
        Camera c = new Camera();
        p.Use(c);
    }
}
