Console.Clear();
Console.Write("Write number: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = String.Empty;
while (n > 0)
{
    result = Convert.ToString(n % 2) + result;
    n = n / 2;
}
Console.WriteLine(result);