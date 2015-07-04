using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_16
    {

        public static long findResult()
        {

            return sumOfDigits(power(1000, 2).ToString());

        }

        public static long sumOfDigits(string x)
        {

            long tempSum = 0;

            foreach (char y in x)
            {

                tempSum += Convert.ToInt32(y.ToString());

            }


            return tempSum;

        }


        public static BigInteger power(int x, int y)
        {

            BigInteger temp = 1;

            for (int i = 1; i <= x; i++)
            {

                temp *= y;

            }

            return temp;

        }
    }
}
