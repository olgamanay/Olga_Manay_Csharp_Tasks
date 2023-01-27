//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.Write("Write number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
    Console.WriteLine("no");
else
{
    while (n > 1000)
    {
    n = n / 10;
    }
    Console.WriteLine(n);
    Console.WriteLine(n % 10);
}

        
    