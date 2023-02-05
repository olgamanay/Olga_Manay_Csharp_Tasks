// string(char)

Console.Clear();
Console.Write("Write amount of massive's elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10, 11); // [-10, 10]

Console.WriteLine($"Rezultat: [{string.Join(", ", array)}];");