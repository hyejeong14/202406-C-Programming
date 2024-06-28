using static System.Console;

class Car
{
    public void Go() { WriteLine("Car Go"); }
    public int GetSpeed() { return 10; }
}

class Program
{
    public static Car MakeCar(int speed)
    {
        return speed < 100 ? new Car() : null;
    }

    public static void Main()
    {
        //		Car c = MakeCar(50); // ok. Car ��ü�� ��ȯ�˴ϴ�.
        Car c = MakeCar(150); // null �� ��ȯ�˴ϴ�.

        //      c.Go(); // c== null �� ��� ���� �߻�.

        // null ���ɼ��� �ִ� ��ü ���ô� �ݵ�� �����ϰ� 
        // ����ϴ� ���� �����մϴ�.
        if (c != null) { c.Go(); }

        // �� �ڵ�� c != null �̸� c.Go()
        // c == null �̸� �ƹ��ϵ� ���� �ʽ��ϴ�.
        // �Ʒ� ������ ���ڵ�� �����մϴ�.
        c?.Go();

        // ? �� �򰥸��� ������

        int? n3; // Ÿ�� ���� ? �Դϴ�. nullable ���� ����
        c?.Go(); // ��ü ���� ? �Դϴ�. c�� null �� �ƴϸ� Go()ȣ��

        int a = n3 ?? 3; // ? �� 2��(??) �Դϴ�.
                         // n3.GetValueOrDefault(3)
    }
}
