using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorsKata
{
    public class PrimeFactors
    {
        public PrimeFactors()
        {
        }

        public List<int> generatePrimeFactors(int n)
        {
            List<int> primes = new List<int>();

            //int tryPrime = 2;
            //while (n > 1)
            //{
            //    while (n % tryPrime == 0)
            //    {
            //        primes.Add(tryPrime);
            //        n /= tryPrime;
            //    }

            //    tryPrime++;
            //}

            for(int tryPrime = 2; n > 1; tryPrime++)
            {
                for(; n%tryPrime == 0; n/=tryPrime)
                {
                    primes.Add(tryPrime);
                }
            }

            return primes;
        }

        static void Main()
        {
        }
    }
}
