﻿Console.Clear();
Console.Write("Write 1st number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Write 2nd number: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n%m ==0)
    Console.WriteLine ("yes");
    else
    Console.WriteLine ($"no, {n%m}");

