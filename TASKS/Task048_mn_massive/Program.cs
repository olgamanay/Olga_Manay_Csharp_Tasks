﻿void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = i + j;
                Console.Write($"{matrix[i, j]} \t"); 
                // \t - табуляция для ровных столбиков
            }
            Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Write massive's size: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);

