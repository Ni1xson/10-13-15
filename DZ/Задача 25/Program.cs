﻿Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int num = a;

for (int i = 1; i < b; i++)
{
    num = num * a;
}
Console.WriteLine("A в степени B равно: " + num);