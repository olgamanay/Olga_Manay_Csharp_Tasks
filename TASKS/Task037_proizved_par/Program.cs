﻿Console.Clear();
void IntupArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9, 9]
}

void ReleaseArray(int[] array)
{
  
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
         Console.Write($"{array[i]  * array[array.Length - i - 1]} ");

}


Console.Clear();
Console.Write("Write array's count: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
IntupArray(array);
Console.WriteLine($"Begining array: [{string.Join(", ", array)}]");
ReleaseArray(array);
