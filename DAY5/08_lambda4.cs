using System;

int Square(int n) { return n * n; }

// #1. lambda expression �� ��Ȯ�� ǥ���
Func<int, int> square1 = int (int n) => { return n * n; };

// �Ʒ� ó�� ����ǥ����� ����.
Func<int, int> square2 = (int n) => { return n * n; };

Func<int, int> square3 = n => n * n; ;