//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.Write("Write number: ");
int n = Convert.ToInt32(Console.ReadLine());
if ((100 <= n <= 999) || (-999 <= n <= -100))
     Console.WriteLine(n % 10);
else if (-99 <= n <= 99)
        Console.WriteLine("no");
else if (n < -1000)
       while (-999 <= n1 <= -100)
      {
        n1 = n / 10;
       Console.WriteLine(n1 % 10);
      }

else (While (100 <= n2 <= 999));
        {
            n2 = n / 10;
            Console.WriteLine(n2 % 10);
        }
       
    