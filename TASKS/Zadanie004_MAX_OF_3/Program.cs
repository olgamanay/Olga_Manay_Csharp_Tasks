Console.Clear();
Console.Write ("Write 1st number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write ("Write 2nd number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write ("Write 3rd number: ");
int p = Convert.ToInt32(Console.ReadLine());

if ((n > m) && (n > p) )
    Console.WriteLine(n);

    else if ((m > n) && (m > p))
    Console.WriteLine(m);

    else if ((p > n) && (p > m))
    Console.WriteLine(p);

    else if ((n == m) && (n > p))
    Console.WriteLine(n);

    else if ((n == m) && ( n < p))
    Console.WriteLine(p);

    else if ((n == p) && (n > m))
    Console.WriteLine(n);

    else if ((n == p) && (n < m))
    Console.WriteLine(m);
    
    else if ((m == p) && (m > n))
    Console.WriteLine(m);

    else if ((m == p) && (m < n))
    Console.WriteLine(n);

    else
     Console.WriteLine("=");