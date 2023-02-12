Console.Clear();
Console.Write("First triangle's side: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Second triangle's side: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Third triangle's side: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a + b > c && b + c > a && a + c > b)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
