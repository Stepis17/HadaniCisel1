using System;

namespace HadaniCisel1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Random random = new Random();
            int nahodne_cislo = random.Next(0, 100);
            double tip;
            bool neuhodl = true;
            while (true)
            {
                Console.WriteLine("Hádání čísla");
                Console.WriteLine("----------------------");
                Console.WriteLine("Myslím si číslo od 0 do 100");
                while (neuhodl)
                {
                    Console.WriteLine("Tipni si číslo");
                    double.TryParse(Console.ReadLine(), out tip);
                    if (tip < nahodne_cislo)
                    {
                        Console.WriteLine("To je málo :( ");
                        Console.WriteLine();
                    }
                    else if (tip > nahodne_cislo)
                    {
                        Console.WriteLine("To je moc :( ");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Trefa");
                        neuhodl = false;
                    }







                }
            }
        }
    }
}







