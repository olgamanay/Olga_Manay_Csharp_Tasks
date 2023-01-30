﻿// Второй максимум (доп)
// Задана последовательность натуральных чисел, 
//завершающихся нулем. Требуется определить
//значение второго по величине элемента в этой 
// последовательности, то есть элемента, который
// будет наибольшим, если из последовательности удалить
// наибольший элемент

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine()), max1 = n, max2 = 0;
while (n !=0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > max1)
    {
        max2 = max1;
        max1 = n;
    }
    else if (n > max2)
        max2 = n;   
}
Console.WriteLine(max2);