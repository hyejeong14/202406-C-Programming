class Program
{
    public static void M1(int a1) { }
    public static void M2(int a1, int a2) { }
    public static void M3(int[] ar) { }
	public static void M4(params int[] ar) { } //가변인자 메소드, M3와 동일하게 배열을 요구하지만 M4(1,2,3) 도 허용함

    public static void Main()
    {
        // M2에는 인자를 2개만 보내야 함
        M2(1,2);   //ok
        M2(1, 2, 3); //error

        //인자의 개수를 가변으로 하려면 배열로 보내면 됨
        M3( new int[] { 1, 2, 3 }); // int[] ar = new int[]{1,2,3} 이므로
        M3 (new[] { 1, 2, 3 }); // int ar = new []{1,2,3}
        M3({1,2,3}); // 이 표기법은 error
        M3([1,2,3]);   // 이 표기법은 허용
        M3(1, 2, 3); // M3는 배열을 인자로 받고 있기 때문에 error 발생

        M4(new int[] { 1, 2, 3 });
        M4(1, 2, 3); // 가능 1,2,3을 컴파일러가 new int[]{1,2,3}으로 변경해줌


    }

    // 주의 사항
    public static void M5(int[] ar, int n) { } //ok			
    public static void M6(params int[] ar, int n) { }	//error

}
	