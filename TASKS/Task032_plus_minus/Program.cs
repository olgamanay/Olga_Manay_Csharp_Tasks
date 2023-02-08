void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10); // [-9, 9]
}

void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= (-1); // array[i] = array[i] * (-1);
}

Console.Clear();
Console.Write("Write array's count: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Begining array: [{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine($"Finishing array: [{string.Join(", ", array)}]");