//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


Console.Clear();
Console.Write ("Write 1st number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write ("Write 2nd number: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n > m)
   Console.WriteLine(n);
   else if (n < m)
   Console.WriteLine(m);
   else
    Console.WriteLine("=");
