void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10); // [-9, 9]
}

void ReleaseArray(int[] array)
{
    int summaPositive = 0, summaNegative = 0;
    foreach (int element in array) // цикл для перебора внутри массива без нумерации
    {
        if (element > 0)
        summaPositive += element;
        else
        summaNegative += element;

    }
    Console.WriteLine($"Positive numbers's sum: {summaPositive}");
    Console.WriteLine($"Negative numbers's sum: {summaNegative}");
}

Console.Clear();
Console.Write("Write array's count: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Begining array: [{string.Join(", ", array)}]");
ReleaseArray(array);