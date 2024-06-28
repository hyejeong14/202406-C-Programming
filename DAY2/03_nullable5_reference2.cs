// 프로그램에서 "name" 은 항상 유효한 값을 가져야 한다.
// => 프로그램의 어디에서도 "name" 을 null 을 가져서는 안된다.
string name = "kim";

Console.WriteLine(name);

name = null // C# 8.0 까지는 에러가 아님. 경고도 없음
            // C# 9.0부터 해당 코드는 null 이 될 수 없음
            // 과거 코드와의 호환성을 고려해 에러는 아니지만 경고로 처리

string s1 = null; // 경고, null을 사용할 수 없는 reference
string s2 = null; // Ok, null이 될 수 있는 reference
                  // 단, 이 코드는 C# 8.0까지 에러

