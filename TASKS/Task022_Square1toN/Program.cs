Console.Clear();
Console.Write("Write one natural number: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i < n + 1; i++)
   {
    Console.Write($"{Math.Pow(i, 2)} ");
   }