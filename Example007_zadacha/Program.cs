﻿Console.Clear();
int xa = 1 ,ya = 1, xb = 1, yb = 30 , xc = 80 , yc = 30;
Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+") ;
Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");
int x = xa , y = xb ;
int count = 0 ;
while(count<10)
{
    int what = new Random().Next(0,3);
    if(what==0)
    {
        x=(x + xa)/2;
        y=(y + ya)/2;

    }
    if(what == 2)
   { x = (x + xc);
    y =(y + yb);
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}    