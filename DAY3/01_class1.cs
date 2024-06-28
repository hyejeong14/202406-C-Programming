﻿using static System.Console;

// C언어 스타일의 함수방식으로 만든 코드

// 사각형의 면적을 구하는 함수 
int GetRectArea(int x1, int y1, int x2, int y2)
{
    return (x2 - x1) * (y2 - y1);
}

int area = GetRectArea(1, 1, 10, 10);
