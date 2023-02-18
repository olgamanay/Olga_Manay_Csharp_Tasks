string rec(int m, int n)
{
    if (m == n)
        return $"{m} ";
    return rec(m, n - 1) + $", {n} ";
}


Console.Clear();
Console.Write("Write 1st number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Write 2ng number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n, m));
