﻿//Zadacha 66

Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);


if (M < N)
{
   Console.WriteLine(SumFromFirstToSecond(M, N)); 
} 
else Console.WriteLine("Ошибка! Введите M < N");

int SumFromFirstToSecond(int firstNum, int secondNum)
{
    if (firstNum == secondNum) return firstNum;
    else return secondNum + SumFromFirstToSecond(firstNum, secondNum - 1);
}