// 30 page ~
// mutable   : 객체의 속성을 변경할 수 있는 것 
// immutable : 객체의 속성을 변경할 수 없는 것 





int[] x = { 1, 2, 3 };
x[0] = 10;

string s = "ABC";
s[0] = 'X'; //error String Type이 imutable한 객체이기 때문

s = 'XYZ'; // 정상 작동  
           // 에러가 나지 않는 이유는?
           // 기존 객체를 변경한 것이 아니라 새로운 객체를 만들고 S가 새로 만들어진 객체를 가르키는 것
           //  s = new string("XYZ")와 같음ㄴ