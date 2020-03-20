using System;
using System.Collections.Generic;
using System.Text;

namespace SirFibonacci
{
    class CalculFibonacci
    {
        public static uint[] CalcFibonacci( int nrValue)
        {
           uint nrIntermed1 = 1;
            uint nrIntermed2 = 1;
           uint[] rezult = new uint[nrValue];
            for(int i = 0; i < nrValue; i++)
            {
                rezult[i] = nrIntermed1 + nrIntermed2;
                nrIntermed2 = nrIntermed1;
                nrIntermed1 = rezult[i];
            }
            return rezult;

        }
     }
}
