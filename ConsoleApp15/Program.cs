using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        int n = 3;
        int m = 2; // dodanie zmiennej, która przechowuje wartość początkową która ma być mnożnikiem (w tym wypadku 2)
        int wynik = 2;

        for (int i = 1; i < n; i++)
        {
            wynik *= m;
        }

        Console.WriteLine($"2^{n} = {wynik}");
    }
}