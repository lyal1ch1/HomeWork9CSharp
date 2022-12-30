// // Zadacha64
// // Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// // N = 5 -> "5, 4, 3, 2, 1"
// // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите N:");
// int number = int.Parse(Console.ReadLine()!);

// string NumberFromToOne(int num)
// {
// if (num == 1)
// {
//   return "1";   
// }
// else
// {
//     return num + " " + NumberFromToOne(num-1);
// }
// }

// Console.WriteLine(NumberFromToOne(number));

// //Zadacha 66

// Console.WriteLine("Введите число M: ");
// int M = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);


// if (M < N)
// {
//    Console.WriteLine(SumFromFirstToSecond(M, N)); 
// } 
// else Console.WriteLine("Ошибка! Введите M < N");

// int SumFromFirstToSecond(int firstNum, int secondNum)
// {
//     if (firstNum == secondNum) return firstNum;
//     else return secondNum + SumFromFirstToSecond(firstNum, secondNum - 1);
// }

//Zadacha 68 
Console.WriteLine("Введите M > 0: ");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите N > 0: ");
int N = int.Parse(Console.ReadLine()!);

if (M < 0 || N < 0) Console.WriteLine("Оба числа должны быть неотрицательными!");
else Console.WriteLine(AckermanFunction(M, N));

int AckermanFunction(int firstNum, int secondNum)
{
    if (firstNum == 0) return secondNum + 1;
        else 
        {
            if (secondNum == 0) return AckermanFunction(firstNum - 1, 1);
            else return AckermanFunction(firstNum - 1, AckermanFunction(firstNum, secondNum - 1));
        }
}
