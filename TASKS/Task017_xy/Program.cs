// Напишите программу, которая принимает на вход 
//координаты точки (Х, У), причем они не равны 0,
// и выдает номер четверти плоскости, в которой находится
// эта точка.

Console.Clear();
Console.Write("Write x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Write y: ");
double y = Convert.ToDouble(Console.ReadLine());

while (x == 0 || y == 0)
{
    Console.WriteLine ("Wrong! Write x and y!");
    Console.Write("Write x: ");
x = Convert.ToDouble(Console.ReadLine());
Console.Write("Write y: ");
y = Convert.ToDouble(Console.ReadLine());
}
if (x > 0 && y > 0)
    Console.WriteLine("1");
else if (x < 0 && y > 0)
    Console.WriteLine("2");
else if (x < 0 && y < 0)
    Console.WriteLine("3");
else
    Console.WriteLine("4");
