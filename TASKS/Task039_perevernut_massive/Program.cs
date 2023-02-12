void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11);
}


void ReplaceElement(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}
Console.Clear();
Console.Write("Write count's numbers of massive: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Beginning massive: [{string.Join(", ", array)}]");
ReplaceElement(array);
Console.WriteLine($"Finishing massive: [{string.Join(", ", array)}]");
