class Example
    
{
    //static method : 객체가 없어도 호출 가능
    //static field  : 모든 객체가 공유, 객체가 없어도 메모리에 존재
    //static method 에서는 static 멤버만 접근할 수 있다.
    public int data1 = 0;
    public static int data2 = 0;

    public void M1()
    {
        //M1이 호출되었다느 것은 객체가 있다는 의미
        data1 = 0; //1  //객체가 있으므로 data1도 있음
        data2 = 0; //2  //ok static field로 객체가 없어도 가능
        M2();      //3  //호출 가능 (객체가 없어도 static method는 호출 가능)
    }

    public static void M2()
    {
        //static 안에서는 static만 호출가능, instance는 호출X
        data1 = 0; //4  //error 객체가 있어야 호출 가능한 field.하지만 M2는 static method로 객체가 없어도 호출 가능함
        data2 = 0; //5  //ok
        M1();      //6  //error  
    }
}

class Program
{
    public static void Main()
    {
        Example.M2(); //static 메소드이므로 객체 없어도 언제라도 호출 가능
    }
}