// C#은 오버로딩 문법을 지원
//  => 인자의 타입이나 갯수가 다르면 동일 이름의 함수를 여러개 만들 수 있다는 것

int Square(int a) { return a * a; }
double Square(double a) { return a * a; }

int n = Square(3);

//컴파일러가 위의 코드를 아래 코드로 변경한 것
//  => Square 함수(메소드)는 Main 메소드 안에서 만들어진 함수
//  => "메소드" 안에서 다시 함수(메소드)를 만드는 것을 nested function 이라고 함.
//  => nested function은 오버로딩이 될 수 없음

class Program
{
    public static void Main()
    {
        int Square(int a) { return a * a; }
        double Square(double a) { return a * a; }

        int n = Square(3);
    }
}
