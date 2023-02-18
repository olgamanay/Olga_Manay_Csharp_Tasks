int f(int n)
{
    if (n == 0)
        return 0;
    
    if (n == 1)
        return 1;
    return f(n - 1) + f(n - 2);
}


Console.Clear();
Console.Write("Write number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));