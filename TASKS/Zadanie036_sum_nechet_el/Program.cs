// Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящий на нечетных позициях

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 101);
}


int SumOddInArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    sum = sum + array[i];
    return sum;
}


Console.Clear();
Console.Write("Write array's count: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Begining array: [{string.Join(", ", array)}]");
Console.WriteLine($"Result: {SumOddInArray(array)} ");
