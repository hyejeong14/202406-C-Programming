// 1번복사

using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry"); }
}
class Dog : Animal
{
    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Program
{
    public static void Main()
    {
        Animal a = new Animal(); a.Cry();  // Animal Cry
        Dog d = new Dog(); d.Cry();  // Dog Cry

        Animal a2 = new Dog();

        a2.Cry();   // 객체는 Dog, 참조 변수는 Animal
                    // C#은 1 ? 2 중 어느 것이 호출될까요 ?
                    // 1 ? 2 중 어느 것을 호출하는 것이 논리적으로 맞을까요 ?
                    // => 객체가 Dog 이므로 당연히 "Dog Cry" 가 논리적으로 맞습니다.

        // C#, C++ : Animal Cry
        // Java, Swift, Python, Kotlin, Objective-C 등 대부분의 객체지향 언어 : Dog Cry
    }
}

