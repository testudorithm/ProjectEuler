using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_7
    {
        private const long number = 600851475143L;

        public static int findResult(int target)
        {

            int counter = 0;

            for (int i = 2; i < number; i++)
            {


                if (isPrimeNum(i))
                {

                    counter++;

                }

                if (counter == target)
                    return i;



            }

            return -1;

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
