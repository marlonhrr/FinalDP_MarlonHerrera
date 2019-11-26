using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumber.Core.Services
{
    public class PrimeService : IPrimeService
    {
        public string GetPrimes(int n)
        {
            int conPri = 0, i = 1;
            string primos = "";
            while (conPri < n)
	        {
                if (IsPrime(i))
                {
                    primos += String.Format("{0:N0\t}", i);
                    conPri++;
                }
                i++;
	        }
            return primos;
        }

        public bool IsPrime(long n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}