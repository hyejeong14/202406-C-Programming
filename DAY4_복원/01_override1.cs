using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry"); }
}
class Dog : Animal
{
    // #1. Dog 는 Animal 로 부터 Cry 메소드를 물려 받게 됩니다.
    // #2. Dog 에서 Cry 메소드를 다시 만들수 있습니다.
    // => "method override" 라고 합니다.
    // => overloading : 인자가 다르면 같은 이름의 함수를 여러개 만들수 있다
    //                  Square(int x), Square(double d)
    // C++ : 그냥 동일이름으로 만들면 됩니다.
    // C#  : 실수가 아니라 의도적으로 override 한다는 것을 알리기 위해
    //       "new" 를 붙이는 것이 좋습니다
    //       "new" 는 생략 가능하지만, 경고 발생
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
