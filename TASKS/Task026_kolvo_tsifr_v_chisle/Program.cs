﻿// Количество цифр в числе


Console.Clear();
Console.Write("Write number: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
while (n > 0)
{
    n = n / 10;
    count++; // count = count + 1
}

Console.WriteLine(count);