using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 24;

            if( sicaklik < (int)HavaDurumu.Normal)
                Console.WriteLine("Hava çok soğuk!");
            else if(sicaklik >= (int)HavaDurumu.Sicak)
                Console.WriteLine("Hava çok soğuk!");
            else if(sicaklik < (int)HavaDurumu.Sicak && sicaklik > (int)HavaDurumu.Soguk)
                Console.WriteLine("Hava güzel!");
        }
    }

    enum Gunler
    {
        Pazartesi =1,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
}
