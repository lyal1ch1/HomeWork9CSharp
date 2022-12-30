﻿// // Zadacha64
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите N:");
int number = int.Parse(Console.ReadLine()!);

string NumberFromToOne(int num)
{
if (num == 1)
{
  return "1";   
}
else
{
    return num + " " + NumberFromToOne(num-1);
}
}

Console.WriteLine(NumberFromToOne(number));

