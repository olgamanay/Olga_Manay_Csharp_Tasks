Console.Clear();
Console.Write("Write number: ");
int n = Convert.ToInt32(Console.ReadLine()), result = 0;
while (n > 0)
{
    result = result + n % 10; // result += n % 10;
    n = n / 10; // n /= 10;
}
Console.WriteLine(result);