// auto-implemented property
class Example
{
    private int data1 = 0;
    
    //필드 한개와 연결된 Property를 만드는 전형적인 코드는 아래와 같음
    public int Data1 
    { 
        get { return data1; } 
        set { data1 = value; } 
    }

    //위 코드에서 set, get은 어떠한 추가적인 로직없이 단지 필드를 직접 r/w (read&write) 하고 있음

    // 아래 한줄이 위 코드와 완전히 동일
    // => 필드 추가되고(이름은 알 수 없음), setter, getter 추가
    // => auto implemented property 라고 함

    public string Name;
    public string Address;

    public
}

class Program
{
    
    public static void Main()
    {

    }
}
