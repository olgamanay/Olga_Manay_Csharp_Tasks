// При вводе номера четверти показывать диапазон 
// возможных координат




Console.Clear();
Console.Write("Write 1 - 4 : ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 1)
    Console.WriteLine("x > 0 and y > 0");
else if (n == 2)
    Console.WriteLine("x < 0 and y > 0");
else if (n == 3)
    Console.WriteLine("x < 0 and y < 0");
else
    Console.WriteLine("x > 0 and y < 0");
