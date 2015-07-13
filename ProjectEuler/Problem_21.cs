using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_21
    {
        public static int findSum()
        {

            int bigSum = 0;

            for (int i = 1; i < 10000; i++)
            {

                if (isAmicableNum(i))
                {

                    bigSum += i;

                }

            }
            return (bigSum);

        }

        public static bool isAmicableNum(int x)
        {

            int temp = sumOfProperDiv(x);

            if (sumOfProperDiv(temp) == x && x != temp)
            {

                return true;

            }

            return false;

        }

        public static int sumOfProperDiv(int x)
        {

            int sum = 0;

            for (int i = 1; i <= x / 2; i++)
            {

                if (x % i == 0)
                {

                    sum += i;

                }

            }

            return sum;

        }
    }
}
