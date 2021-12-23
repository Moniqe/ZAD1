using System;

namespace Zad3Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikacja kalkulator tylko mnożenie!");

            Console.WriteLine("Podaj proszę 1 liczbę:");

            var liczba1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj proszę 2 liczbę:");

            var liczba2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz '+' lub '-'");
            var operacja = Console.ReadLine();
            var wynik = 0;
            if ("+".Equals(operacja)) wynik = liczba1 + liczba2;
            else if ("-".Equals(operacja)) wynik = liczba1 - liczba2;
            else Console.WriteLine("Zły znak!");

            Console.WriteLine($"Wynik Twojego działania to: {wynik}.");
        }
    }
}
