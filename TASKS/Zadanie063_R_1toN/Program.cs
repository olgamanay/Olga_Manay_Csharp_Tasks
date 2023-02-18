// 63 - Вывод всех натуральных чисел от 1 до N

string f(int n)
{
    if (n == 1)
        return "1 ";
    return f(n - 1) + $", {n} ";
}


Console.Clear();
Console.Write("Write number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));