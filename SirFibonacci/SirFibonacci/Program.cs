using System;

namespace SirFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadAndPrintFibonacci();

        }
        private static void ReadAndPrintFibonacci()
        {
            int defaultValue =  ConsoleHelper.ReadNumber("Numar : ", 5, 1);

            Console.WriteLine($"Numarul este : {defaultValue}");
           uint[] vectorFibonacci = new uint[defaultValue];
            vectorFibonacci = CalculFibonacci.CalcFibonacci(defaultValue);
            AfisareHelper.AfisareSir(vectorFibonacci, defaultValue);

        }

    }
}
