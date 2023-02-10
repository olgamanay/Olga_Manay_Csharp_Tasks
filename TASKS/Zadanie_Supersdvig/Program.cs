﻿Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int[] arrayFirst = new int[n];
int[] arrayResult = new int[n];
for (int i = 0; i < arrayFirst.Length; i++)
{
   arrayFirst[i] = new Random().Next(1, 11);
}
Console.WriteLine($"[{string.Join(", ", arrayFirst)}]");
int k = Convert.ToInt32(Console.ReadLine());
k = k % n;
if (k > 0)
{
    for (int i = 0; i < k; i++)
        arrayResult[i] = arrayFirst[n - k + i];
    for (int i = 0; i < n - k; i++)
        arrayResult[k + i] = arrayFirst[i];
    Console.WriteLine($"[{string.Join(", ", arrayResult)}]");
}
else
{
    k = (-1) * k;
    for (int i = 0; i < k; i++)
        arrayResult[n - k + i] = arrayFirst[i];
    for (int i = 0; i < n - k; i++)
        arrayResult[i] = arrayFirst[k + i];
Console.WriteLine($"[{string.Join(", ", arrayResult)}]");

}