// А в степени Б (ввод в ручную)

Console.Clear();
Console.Write("Write 1st number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Write 2nd number: ");
int m = Convert.ToInt32(Console.ReadLine()), result = 1;
for (int i = 1; i <= m; i++)
    result = result * n; // result *= n;
Console.WriteLine(result);    
