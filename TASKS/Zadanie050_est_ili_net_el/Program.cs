void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * (20 + 20) - 20, 2);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


double SearchElementToMatrix(double[,] matrix, int row, int column)
{
    if (matrix.GetLength(0) > row && matrix.GetLength(1) > column && row >= 0 && column >= 0)
        return matrix[row, column];
    return 0;
}


Console.Clear();
Console.Write("Write massive's size: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);
int[] coord = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
Console.Write("Write element's position: ");
double result = SearchElementToMatrix(matrix, coord[0] - 1, coord[1] - 1); // Для пользователя счет идет не с 0, а с 1
if (result != 0) // result не равен 0
    Console.WriteLine(result);
else
    Console.WriteLine("This number is not");
