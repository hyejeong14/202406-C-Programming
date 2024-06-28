using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry"); }
}
class Dog : Animal
{
    // #1. Dog �� Animal �� ���� Cry �޼ҵ带 ���� �ް� �˴ϴ�.
    // #2. Dog ���� Cry �޼ҵ带 �ٽ� ����� �ֽ��ϴ�.
    // => "method override" ��� �մϴ�.
    // => overloading : ���ڰ� �ٸ��� ���� �̸��� �Լ��� ������ ����� �ִ�
    //                  Square(int x), Square(double d)
    // C++ : �׳� �����̸����� ����� �˴ϴ�.
    // C#  : �Ǽ��� �ƴ϶� �ǵ������� override �Ѵٴ� ���� �˸��� ����
    //       "new" �� ���̴� ���� �����ϴ�
    //       "new" �� ���� ����������, ��� �߻�
    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Program
{
    public static void Main()
    {
        Animal a = new Animal();
        a.Cry();    // Animal Cry

        Dog d = new Dog();
        d.Cry();    // Dog Cry
    }
}
