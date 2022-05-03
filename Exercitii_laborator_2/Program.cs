using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti un program care va afisa factorialul
            // unui numar n, n fiind citit de la tastatura.

            Console.WriteLine("Introduceti numarul");
            int n = int.Parse(Console.ReadLine());

            int factorial = 1;

            if (n < 0)
            {
                Console.WriteLine("Numarul nu poate fi negativ");
                return;
            }

            for (int i = n; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine($"Rezultatul este  -> {factorial}");
        }
    }
}
