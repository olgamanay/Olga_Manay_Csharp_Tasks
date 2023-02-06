// Произведение чисел от 1 до введенного числа


Console.Clear();
Console.Write("Write number: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 1;
for (int i = 2; i <= n; i++)
   count = count * i;

Console.WriteLine(count);
