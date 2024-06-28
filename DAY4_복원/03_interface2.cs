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
        p.Use(hc); //People�� Camera�� ���ڷ� �ޱ� ������ hdcamera�� ������ -> �����ε��ϸ� ���� �� ���� �ٵ� Ȯ�强�� ����!
    }
}
