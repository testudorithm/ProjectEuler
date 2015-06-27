using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_10
    {
        public static long findSumofPrimes(int limit)
        {

            long result = 0;

            for (long i = 0; i < limit; i++)
            {

                if (isPrimeNum((int)i))
                    result += i;

            }

            return result;

        }

        public static bool isPrimeNum(int x)
        {

            for (int i = 2; i <= x; i++)
            {

                if (i != x && x % i == 0)
                {

                    return false;

                }

            }

            if (x < 2)
                return false;

            return true;

        }
    }
}
