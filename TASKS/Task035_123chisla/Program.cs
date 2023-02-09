Console.Clear();
void IntupArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101); // [-100, 100]
}

int ReleaseArray(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element >= 10 && element <= 99)
            count++;
    }
    return count;
}


Console.Clear();
// Console.Write("Write array's count: ");
// int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[123];
IntupArray(array);
Console.WriteLine($"Begining array: [{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray(array));
