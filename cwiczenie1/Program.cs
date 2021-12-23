using System;

namespace cwiczenie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int iloczyn = 1;
            Console.WriteLine("Podaj liczbe");
            int liczba = int.Parse(Console.ReadLine());
            for (int licznik = 1; licznik <= liczba; licznik ++)  
            {
                iloczyn = iloczyn * licznik; 
                Console.WriteLine(" silnia liczby " + licznik + " jest równa " + iloczyn);
            }
             
            
        }
    }
}
