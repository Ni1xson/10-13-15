﻿Console.WriteLine("введите число");
int number = int.Parse(Console.ReadLine());
int pal = 0, num = number;
while (number > 0) { pal = pal * 10 + number % 10; number /= 10; }
Console.WriteLine(num == pal ? "палиндром" : "не палиндром");
