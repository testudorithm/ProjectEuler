using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_9
    {
        private static long limit = 1000;

        public static int calculatePythagoreanTriplet()
        {

            for (int i = 1; i < limit; i++)
            {

                for (int j = i + 1; j < limit; j++)
                {

                    int tempThirdNum = getPythThirdNum(i, j);

                    if (tempThirdNum != -1 && (tempThirdNum + i + j) == 1000 && (j < tempThirdNum))
                    {

                        return i * j * tempThirdNum;

                    }

                }

            }

            return -1;

        }


        public static int getPythThirdNum(int i, int j)
        {


            int pythSum = (i * i) + (j * j);
            double pythSqrt = Math.Sqrt(pythSum);

            if (((int)pythSqrt * (int)pythSqrt) == (pythSum))
            {

                return (int)pythSqrt;

            }

            return -1;


        }
    }
}
