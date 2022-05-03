using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti un program care va determina daca un numar este sau nu palindrom

            Console.WriteLine("Introduceti numarul");

            string numarIntrodus = Console.ReadLine();
            double valoare = double.Parse(numarIntrodus);

            long numar = (long)valoare;
            string numarInversat = "";

            if (numar < 10)
            {
                Console.WriteLine("Numarul trebuie sa fie pozitiv si format din minim 2 cifre");
                return;
            }

            while (numar != 0)
            {
                numarInversat += (numar % 10).ToString();
                numar = numar / 10;
            }

            if (numarIntrodus == numarInversat) 
            {
                Console.WriteLine($"Numarul este un palindrom:   {numarIntrodus} = {numarInversat}");
            }
            else
            {
                Console.WriteLine($"Numarul {numarIntrodus} nu este un palindrom");
            }
        }
    }
}
