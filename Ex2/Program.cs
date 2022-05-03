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

            int[] sir = new int[lungimeSir];
            if (lungimeSir < 2)
            {
                Console.WriteLine("Sirul nu poate avea mai putin de 2 numere");
                return;
            }

            Console.WriteLine("Introduceti numerele");
            for (int i = 0; i < sir.Length; i++)
            {
                sir[i] = int.Parse(Console.ReadLine());

                if (sir[i] <= 0)
                {
                    Console.WriteLine("Numerele nu trebuie sa fie mai mici decat 0");
                    return;
                }
            }

            int total = 0, numerePare = 0;
            double mediaAritmetica = 0;

            for (int i = 0; i < sir.Length; i++)
            {
                if (sir[i] % 2 == 0)
                {
                    total += sir[i];
                    numerePare++;
                }
                else
                {
                    total += 0;
                }
            }

            mediaAritmetica = (double)total / numerePare;

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
