using System;

int Square(int n) { return n * n; }

// #1. lambda expression 의 정확한 표기법
Func<int, int> square1 = int (int n) => { return n * n; };

// 아래 처럼 단축표기법도 가능.
Func<int, int> square2 = (int n) => { return n * n; };

Func<int, int> square3 = n => n * n; ;