using static System.Console;

// 강한 결합(tightly coupling)
// => 하나의 클래스가 다른 클래스 사용시 이름을 직접 사용하는것
// => Use(Camera c)
// => 교체 불가능한 경직된 디자인


// 약한 결합(loosely coupling)
// => 하나의 클래스가 다른 클래스 사용시 이름을 직접 사용하지 않고
//    규칙을 담은 인터페이스를 사용해서 접근 하는 것
// => Use(ICamera c)
// => 교체 가능한 유연한 디자인


// 카메라와 카메라 사용자 코드를 먼저 만들지 말고
// 지켜야 하는 규칙을 먼저 설계 합니다.

// 규칙 : 모든 카메라는 아래 인터페이스로 부터 "파생"되어야 한다. 라고 표현하지 말고
//       모든 카메라는 아래 인터페이스를 "구현해야" 한다. 라고 표현 합니다.

interface ICamera
{
    void Take();
}

// 이제 카메라 사용자는 "구체적인 제품이름을 알필요 없고,
// "제품이름을 직접 사용하는 것은 좋지도 않습니다."
// "규칙대로만 사용하는 것이 좋습니다.
class People
{
    public void Use(ICamera c) { c.Take(); }
}

// 이제, 모든 카메라 제품은 규칙대로 설계되어야 합니다.

class Camera : ICamera
{
    public void Take() => WriteLine("Take a picture");
}

class HDCamera : ICamera
{
    public void Take() => WriteLine("Take a HD picture");
}

// UHDCamera 를 추가해 보세요
// Main 에서 객체를 생성해서 사용해 보세요
class UHDCamera : ICamera
{
    public void Take() => WriteLine("Take a UHD picture");
}

class Program
{
    public static void Main()
    {
        People p = new People();
        Camera c = new Camera();
        p.Use(c);

        HDCamera hc = new HDCamera();
        p.Use(hc);

        UHDCamera uhc = new UHDCamera();
        p.Use(uhc);

    }
}

/*
// 카메라 만들때 규칙을 지키지 않아도 사용가능하지만
class GoodCamera
{
    public void Take() => WriteLine("Take Good Picture");
}

GoodCamera gc = new GoodCamera();
gc.Take(); // ok. 

// 하지만 규칙대로 사용하는 클래스(people)에 보낼수는 없습니다.
p.Use(gc); // error
*/