﻿// Напишите программу, которая на вход принимает координаты точки (Х;У),
//при чем Х не равно нулю, и У не равно нулю и выдает номер четверти плоскости,
//в которой находится эта точка.

void Quarters(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x=0, y=0");
    else if (x > 0 && y > 0)
        Console.WriteLine("I");
    else if (x < 0 && y > 0)
        Console.WriteLine("II");
    else if (x < 0 && y < 0)
        Console.WriteLine("III");
    else if (x > 0 && y < 0)
        Console.WriteLine("IV");

}

int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
Quarters(num_1, num_2);

