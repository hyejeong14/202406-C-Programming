class Animal
{
    public int Age { get; set; } = 0;
}

class Dog : Animal
{
    public int Color { get; set; } = 0;
}

class Program
{
    public static void Main()
    {
        Animal a = new Dog();

        //실행시간 입력결과에 따라 a가 가리키는 객체가 변경
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            a = new Animal();
        }


        //a가 가리키는 객체는 실행 시 사용자 입력에 따라 Color가 있을 수도~ 없을 수도~

        //static type check : Color가 없을 수도 있으니 컴파일 시간 에러 발생
        //dynamic type check : 컴파일은 허용하지만 실행 시 Color가 없으면 예외 처리
        // a.Color = 0; //C#은 static type check. error 발생

        //a가 가리키는 곳이 Dog라는 확신이 없다면 조사
        // 1. if
        if (a is Dog)
        {
            Dog d0 = (Dog)a;
            d0.Color = 10;

        }

        if (a is Dog d)
        {
            d.Color = 10;
        }


        // 2. as
        Dog d1 = (Dog)a; //a가 Dog가 아니면 runtime 에러
        Dog d2 = a as Dog; //a가 Dog가 아니며 null

        if (d2 != null)
        {
            d2.Color = 10;
        }

    }
}