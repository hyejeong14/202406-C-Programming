// 2번 복사
// 1번 복사

// auto implemented property vs public 필드


class Person
{
    // 아래 코드는 필드가 아닌 속성
    // => get,set 중 한 개만 제공할 수도 있음
    //public string Name { get; } //get only, setter 없음. 생성자에서 set 가능

    public string Name { get; private set; } //setter는 있지만 private으로 접근 제어
                                             // 자신의 모든 메소드에서는 접근 가능하다 외부에서는 접근 안됨
    public string Address { get; set; }

    public Person(string name, string address)
    {
        Name = name;            //name은 get-only
                                //auto property는 생성자에서 접근 가능
                                //auto가 아닌 경우는 필드 이름 사용하면 됨
                                //auto는 필드 이름을 알 수 없으므로 초기화를 허용하기 위해

        Address = address;      //
    }
}

class Program
{
    public static void Main()
    {
        Person p = new("kim", "seoul");

        // public 필드는 항상 R/W 가능합니다.
        //p.Name = "kim";      // error. R(get)만 가능
        string s = p.Name;    // ok get 가능
        p.Address = "seoul"; // r/w가능
    }
}


// 추가적으로 속성으로 만들면
// 객체가 가진 모든 속성을 자동으로 열거해서 출력해 주는 라이브러리들이 있음
// "Name, Address" 를 필드로 만들면 아래와 같은 기능 사용할 수 없음, public 필드여도 못찾음

//아래 코드는 WPF 라이브러리 예제
//DataGrid g = new DataGrid();
//g.Add(p); //p가 가진 속성의 모든 값을 자동으로 보여주는 기능