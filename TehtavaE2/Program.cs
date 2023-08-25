using System;

namespace NumeroJatkuu
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Syötä suurempi kokonaisluku kuin 10: ");
                int luku = int.Parse(Console.ReadLine());

                if (luku <= 10)
                {
                    Console.WriteLine("Syöttämäsi luku ei ole suurempi kuin 10.");
                    return;
                }

                int toistojenMäärä = luku + 2;  // 2 ylimääräistä kertaa (13 ja 131313)

                // Tulostetaan luku toistojen määrän mukaisesti
                for (int i = 0; i < toistojenMäärä; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{luku} ");  // Tulostetaan luku ja välilyönti
                    }
                    else
                    {
                        Console.Write($"{luku}{luku}");  // Tulostetaan luku ilman välilyöntiä
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Virheellinen syöte. Syötä kokonaisluku.");
            }
        }
    }
}
