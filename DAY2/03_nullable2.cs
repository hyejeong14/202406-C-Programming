string s = null; // reference type
int? n = null; // Nullable<int>

// #1. 변수가 null 인지 확인하는 방법
// == 연산자
if (s == null) { }
if (n == null) { }

// is 연산자 - 내일 자세히 등장.
if (s is null) { }
if (n is null) { }

// HasValue 속성 사용
if (s.HasValue) { } // error. reference type 은 이 속성없습니다.
if (n.HasValue) { } // ok.    Nullable<T> 는 있습니다.