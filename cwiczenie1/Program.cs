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
            Console.WriteLine("Wpisz '+' , '-' , '*'");
            var operacja = Console.ReadLine();
            var wynik = 0;
            switch (operacja)
            {
                case "*": wynik = liczba1 * liczba2;   
                    break;
                case "+":  wynik = liczba1 + liczba2; 
                    break;
                case "-":  wynik = liczba1 - liczba2; 
                    break;
                default: Console.WriteLine("Zły znak!");
                    break;

            }

            Console.WriteLine($"Wynik Twojego działania to: {wynik}.");
        }
    }
}
