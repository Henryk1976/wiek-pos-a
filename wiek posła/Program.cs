using System;

namespace wiek_posła
{
    internal class Program
    {
        static void Main(string[] args)

            //Zadanie nr 5 tydzień 2
        {
            Console.WriteLine("Wiek uprawniający do kandydowania na posła, premiera,senatora");
            Console.WriteLine("Podaj swój wiek: ");

            string liczba = Console.ReadLine();

            int a = int.Parse(liczba);

            if (a >= 21 && a < 25)
            {
                Console.WriteLine("Możesz zostać posłem");
            }
            else if (a >= 25 && a < 30)   //strzelam, bo nie wiem jaki jest wymagany wiek na Pinokia
            {
                Console.WriteLine("Możesz zostać posłem lub premierem");
            }
            else if (a >= 30)
            {
                Console.WriteLine("Możesz zostać posłem,premierem lub senatorem");
            }

        }
    }
}
