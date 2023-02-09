void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10); // [-9, 9]
}

string ReleaseArray(int[] array, int number)
{
    foreach(int element in array)
    {
        if (element == number)
            return "yes";
    }
    return "no";
}

Console.Clear();
Console.Write("Write array's count: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Begining array: [{string.Join(", ", array)}]");
Console.Write("Write number, which do you find: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReleaseArray(array, number));
