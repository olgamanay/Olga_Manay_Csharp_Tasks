// Возвести число a в степень b с помощью рекурсии

int f(int a, int b)
{
    if (b == 0)
        return 1;
    return f(a, b - 1) * a;
}


Console.Clear();
Console.Write("Write number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Write power: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n, m));
