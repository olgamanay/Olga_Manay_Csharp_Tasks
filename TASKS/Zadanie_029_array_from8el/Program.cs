Console.Clear();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(); //не понимаю как ввести 8 числовой массив в ручную (запросить у пользователя)
Console.WriteLine($"Result: [{string.Join(", ", array)}]");
