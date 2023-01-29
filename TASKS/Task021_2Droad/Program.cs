Console.Clear();
Console.Write("Write x1 : ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Write x2 : ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Write y1 : ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Write y2 : ");
double y2 = Convert.ToDouble(Console.ReadLine());

double l = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)), 2);
Console.WriteLine(l);
