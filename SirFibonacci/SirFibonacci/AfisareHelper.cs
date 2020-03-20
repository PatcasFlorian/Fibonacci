using System;
using System.Collections.Generic;
using System.Text;

namespace SirFibonacci
{
    class AfisareHelper
    {
        public static void AfisareSir(uint[] vectorFibonacci,int defaultValue)
        {
            for (int i = 0; i < defaultValue; i++)
            {
                Console.WriteLine($"Sirul Fibonacci : {vectorFibonacci[i]}");
            }
        }
        
    }
}
