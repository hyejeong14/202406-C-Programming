// 19page ~ 
//C#에는 nint라는 data type이 있는데 native int? 라고 os에 따라 크기가 달라짐(C언어의 특징을 따라함)
//해당 데이터타입은 C와의 호환성을 위해 만들어 둠



// #1. Data type
int    n = 0;
double d = 3.4;
char   c = 'A';
string s = "hello";


// #2. var : 우변 초기값으로 컴파일러가 좌변의 타입을 결정
int v1 = 10;		
int v2 = 20;        // int v2
var v3 = 3.4;       // double v3
var v4 = "hello";   //string v4


// #3. literal
int a1 = 10;		// 10진수
int a2 = 0x10;      // 16wlstm
int a3 = 0b10;      // 2진수

int b1 = 1000000;	// 큰 값을 사용하는 경우
int b2 = 1_000_000;  // 자리수 표기법


//빌드하면 생성되는 파일은
//  => bin/debug/net8.0/DAY1.exe 에 있음

// windows 시작 버튼 누르고 visual studio 2022 폴더 실행
//  => "developer command prompt" 실행

//좋은 도구
// 1. ildasm.exe => visual studio 설치 시 설치됨
// 2. linqpad.exe => 구글에서 linqpad 검색 후 무료버전 설치



