class Animal       { public int Age { get; set; } = 0; }

class Dog : Animal { public int Color { get; set; } = 0;}
class Cat : Animal { public int Speed { get; set; } = 0;}

class Program
{
    //모든 동물은 1년이 지나면 1살이 증가
    //pulbic static void NewYear(Dog obj) //Dog만 전달 받을 수 있음
    public static void NewYear( Animal obj )//모든 동물을 받을 수 있음
    {
        ++(obj.Age);
    }

    //참고
    //public static void NewYear(object obj) {}
    //위의 코드의 경우 int 형식까지 받게 되는데 int는 받을 필요가 없기 때문에 XX
    public static void Main()
    {
        Dog d = new Dog();
        Cat c = new Cat();

        //Upcasting 활용 (장점) #2. 동종을 보관하는 배열 만들기
        Dog[] arr1 = new Dog[10];    //Dog 객체의 참조만 보관 가능
        Animal[] arr2 = new Animal[10]; //모든 동물의 참조를 보관 가능 

        arr2[0] = new Dog();
        arr2[1] = new Cat();
    }

  
    
}