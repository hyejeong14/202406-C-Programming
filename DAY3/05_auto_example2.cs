// 1번 복사

// auto implemented property vs public 필드


class Person
{
    // 아래 코드는 필드가 아닌 속성
    // => get,set 중 한 개만 제공할 수도 있음
    public string Name { get; }
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
        Person p = new("kim","seoul");

        // public 필드는 항상 R/W 가능합니다.
        //p.Name = "kim";      // error. R(get)만 가능
        string s = p.Name;    // ok get 가능
        p.Address = "seoul"; // r/w가능
    }
}