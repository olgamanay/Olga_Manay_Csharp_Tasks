Console.Clear();
Console.Write ("Write W/day: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n<5);
// && - и (логическое умножение), нужно выполнение всех условий
// || - или (логическое сложение), достаточно выполнение хотя бы одного условия
// True - 1
// False - 0
while (n < 1 || n >7)
{
Console.Write("You wrong!\nWrite w/day: ");
n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
Console.Write("Monday ");
else if (n == 2)
Console.Write("Tuesday ");
else if (n == 3)
Console.Write("Wednesday ");
else if (n == 4)
Console.Write("Thursday ");
else if (n == 5)
Console.Write("Friday ");
else if (n == 6)
Console.Write("Saturday ");
else
Console.Write("Sunday ");
