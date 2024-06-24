//11page

//System = namespace 이름
//Console = Class 이름
//WriteLine = static method (객체를 생성하지 않아도 클래스 이름을 사용해서 호출 가능한 메서드)

//System.Console.WriteLine("Hello"); //정확한 표기법

using System; // 해당 네임스페이스 사용u
using static System.Console; // 클래스 이름없이 static 메소드 호출가능
// => static 메소드를 Class이름 없이 사용 가능하게 하는 문구

Console.WriteLine("Hello"); //using System 사용시 네임스페이스는 적지 않아도 됨. C# 9.0부터 자동으로 추가
WriteLine("Hello"); //using static System.Console 사용시 메소드명만 적어도 됨