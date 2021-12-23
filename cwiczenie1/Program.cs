using System;

namespace cwiczenie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int iloczyn = 1;

            for (int licznik = 1; licznik <= 9; licznik ++)  
            {
                iloczyn = iloczyn * licznik; 
                Console.WriteLine(" silnia liczby " + licznik + " jest równa " + iloczyn);
            }
            iloczyn = 1;
            for (int licznik = 1; licznik <= 20; licznik++)
            {
                iloczyn = iloczyn * licznik;
                Console.WriteLine(" silnia liczby " + licznik + " jest równa " + iloczyn);
            }
            iloczyn = 1;
            for (int licznik = 1; licznik <= 243; licznik++)
            {
                iloczyn = iloczyn * licznik;
                Console.WriteLine(" silnia liczby " + licznik + " jest równa " + iloczyn);
            }
        }
    }
}
