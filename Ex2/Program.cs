using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Să se scrie un program care citeşte de la tastatură un şir de n numere naturale
            // şi determină media aritmetică a celor pare, n fiind citit de la tastatra.

            Console.WriteLine("Cate numere are sirul ?");
            int lungimeSir = int.Parse(Console.ReadLine());

            int total = 0, numerePare = 0;

            if (lungimeSir < 2)
            {
                Console.WriteLine("Sirul nu poate avea mai putin de 2 numere");
                return;
            }

            for (int i = 0; i < lungimeSir; i++)
            {
                int aux = int.Parse(Console.ReadLine());

                if (aux <= 0)
                {
                    Console.WriteLine("Numerele nu trebuie sa fie mai mici decat 0");
                    return;
                }

                if (aux % 2 == 0)
                {
                    total += aux;
                    numerePare++;
                }
                else
                {
                    total += 0;
                }
            }

            double mediaAritmetica = (double)total / numerePare;

            if (total == 0)
            {
                Console.WriteLine("Nu ati introdus numere pare");
            }
            else
            {
                Console.WriteLine($"Media aritmetica a celor {numerePare} numere pare este  -> {mediaAritmetica}");
            }

        }
    }
}
