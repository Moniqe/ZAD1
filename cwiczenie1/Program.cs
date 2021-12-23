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

            var wynik = liczba1 * liczba2;

            Console.WriteLine($"Wynik Twojego działania to: {wynik}.");
        }
    }
}
