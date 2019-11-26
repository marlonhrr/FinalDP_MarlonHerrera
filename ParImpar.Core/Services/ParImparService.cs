using System;
using System.Collections.Generic;
using System.Text;

namespace ParImpar.Core.Services
{
    public class ParImparService : IParImparService
    {
        public string GetParImpar(int n)
        {
            if (n % 2 == 0)
            {
                return ("The number: " +n+ " is pair");
            }

            return ("The number: " + n + " is odd");
        }
    }
}
