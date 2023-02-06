// Function (void). Функции и процедуры (void)


int f(int a, int b)
{
    if (a > b)
        return a;
    return b;
}

int a = 10, b = 7;
int result = f(a, b);
Console.WriteLine(result);