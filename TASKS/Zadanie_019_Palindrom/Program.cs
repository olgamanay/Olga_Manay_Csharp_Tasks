﻿Console.Clear();
Console.Write("Write number(5): ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000;
int n2 = (n / 1000) % 10;
int n4 = (n % 100) / 10;
int n5 = n % 10;
if (n1 == n5 && n2 == n4)
   Console.WriteLine("yes");
else
    Console.WriteLine("no");
