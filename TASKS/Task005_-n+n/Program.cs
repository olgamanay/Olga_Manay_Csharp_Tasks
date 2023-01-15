Console.Clear();
Console.Write ("Write number: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = -n;
while (m <= n)
{
    Console.Write($"{m} ");
    m = m + 1; // или можно сделать сокращение m = m++
}