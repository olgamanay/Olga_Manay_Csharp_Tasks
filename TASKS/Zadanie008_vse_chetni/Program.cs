Console.Clear();
Console.Write ("Write number: ");
int n = Convert.ToInt32(Console.ReadLine());

int m = Convert.ToInt32(Console.ReadLine());
m = n % 2;

int a = Convert.ToInt32(Console.ReadLine());
// не понимаю как в этой задаче объединить цикл, который будет искать все гласные, и ограничить их в пределе от 2 до мах (n or n-1)
if ((m = 0) && (a > 1))
{
Console.Write($"{a} ");
a = n - 2;
}
else
{
Console.Write($"{a+1} ");
a = n - 2;
}
