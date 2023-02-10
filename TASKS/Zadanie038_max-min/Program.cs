void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (10 - 1) + 1, 2); //[1, 10];
        // формула находит дробные числа от 1 до 10
        // ...* (end - begin) + begin;
}


string DiffMaxAndMin(double[] array)
{
   double minArray = array[0], maxArray = array[0];
   foreach (double element in array)
   {
    if (element > maxArray)
        maxArray = element;
    if (element < minArray)
        minArray = element;
   }

//return $"{maxArray.ToString()} - {minArray.ToString()} = {maxArray - minArray}";
return $"{maxArray} - {minArray} = {maxArray - minArray}";

}


Console.Clear();
Console.Write("Write array's count: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Begining array: [{string.Join(", ", array)}]");
Console.WriteLine($"Result: {DiffMaxAndMin(array)} ");
