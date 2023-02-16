void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
 
            matrix[i, j] = new Random().Next(1, 100);
            
    }
}


void Change(int[,] matrix, int[,] temp)
{
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < 1; j++)
        {
            temp[i, j] = matrix[i, j];

        }
        Console.WriteLine($"Result sr arifm: {j + 1} = {sum / matrix.GetLength(0)}");
    }
}


Console.Clear();
Console.Write("Write row's number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Write column's number: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
int[,] temp = new int[n, m];
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Change row to column: ");
Change(matrix, temp);
PrintMatrix(matrix);

