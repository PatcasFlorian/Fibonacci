using System;
using System.Collections.Generic;
using System.Text;

namespace SirFibonacci
{
    public static class ConsoleHelper
    {
        public static int ReadNumber(string message,int maxAttemps,int defaultValue)
        {
            int attemptsCount = 1;
            bool isNumber = false;
            while(!isNumber)
            {
                Console.Write(message);
                string text = Console.ReadLine();
                isNumber = int.TryParse(text, out int number);

                if (isNumber)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine($"'{text}' os not a nuber , tray again ({maxAttemps-attemptsCount} attempts remaning)...");
                }

                attemptsCount++;
                if (attemptsCount > maxAttemps)
                {
                    Console.WriteLine($" Max attempts countexceeded , asuming {defaultValue} as default value");
                    return defaultValue;
                }
            }
            return defaultValue;

        }

        internal static void ReadNumber(string v)
        {
            throw new NotImplementedException();
        }
    }
}
