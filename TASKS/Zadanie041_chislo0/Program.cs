Console.Clear();
Console.Write("Write number: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write("Write number: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
        count++;   
}
Console.Write($"Result: {count}");

