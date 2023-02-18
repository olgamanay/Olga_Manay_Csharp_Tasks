// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int UserWriteNumber()
{
    Console.Write("Write number: ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumMN(int M, int N)
{
    if (N == M) return M;
    else return N + SumMN(M, N - 1);
}

int number1 = UserWriteNumber();
int number2 = UserWriteNumber();
Console.WriteLine($"Sum from {number1} to {number2} = {SumMN(number1, number2)}");

