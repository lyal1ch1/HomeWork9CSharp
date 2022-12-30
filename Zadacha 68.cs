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
