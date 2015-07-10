using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler
{
    class Problem_20
    {
        public static long findResult(int target){

            BigInteger fact = 1;

            for (int i = 1; i <= target; i++) {

                fact *= i;

            }

            return getDigitSum(fact);

        }

        public static long getDigitSum(BigInteger x) {

            string tempInt = x.ToString();
            long sum = 0;

            foreach(char ch in tempInt){

                sum += Convert.ToInt32(ch.ToString());

            }

            return sum;

        }
    }
}
