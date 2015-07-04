using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler
{
    class Problem_15
    {
        private static int matrixEdgeNum = 20;

        public static BigInteger findResult()
        {

            return takeFac(matrixEdgeNum * 2) / (takeFac(matrixEdgeNum) * takeFac(matrixEdgeNum));

        }

        public static BigInteger takeFac(int x)
        {

            BigInteger temp = 1;

            for (int i = 1; i <= x; i++)
            {

                temp *= i;

            }

            return temp;

        }
    }
}
