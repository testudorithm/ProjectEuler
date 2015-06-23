using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_6
    {
        public static int theSumOfTheSquares(int limit)
        {

            int result = 0;

            for (int i = 1; i <= limit; i++)
            {

                result += takeSquare(i);

            }

            return result;

        }

        public static int theSquareOfTheSum(int limit)
        {

            int result = 0;

            result = (limit * (limit + 1)) / 2;

            return takeSquare(result);

        }

        public static int takeSquare(int x)
        {

            return x * x;
        }
    }
}
