//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да 7 -> да 1 -> нет

Console.Clear();
Console.Write("Write weeks number (1-7): ");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 1 && n <= 5)
   Console.WriteLine("Not holiday");
   else (n == 6 || n == 7)
    Console.WriteLine("It is holiday");
