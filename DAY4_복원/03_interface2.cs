using static System.Console;

class Camera
{
    public void Take() => WriteLine("Take a picture");
}

class HDCamera
{
    public void Take() => WriteLine("Take a HD picture");
}

class People
{
    public void Use(Camera c) => c.Take();
    public void Use(HDCamera c) => c.Take();
}

class Program
{
    public static void Main()
    {
        People p = new People();
        Camera c = new Camera();
        p.Use(c);

        HDCamera hc= new HDCamera();
        p.Use(hc); //People은 Camera를 인자로 받기 때문에 hdcamera는 못받음 -> 오버로딩하면 받을 수 있음 근데 확장성이 없다!
    }
}
