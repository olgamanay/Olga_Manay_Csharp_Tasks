Console.Clear();
Console.Write ("Write number: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
while (count <= n)
{
  count = count + 2;
  Console.Write($"(count) ");  
}

