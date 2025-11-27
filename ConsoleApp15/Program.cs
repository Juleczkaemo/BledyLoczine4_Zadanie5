using System;

class Program
{
    static void Main()
    {
        int n = 3;
        int wynik = 2;

        for (int i = 1; i < n; i++)
        {
            wynik *= i;
        }

        Console.WriteLine($"2^{n} = {wynik}");
    }
}