using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_12
    {
        //public static void Main(string[] args)
        //{

        //    Console.WriteLine("Result : " + findResult(500));

        //    Console.ReadLine();

        //}

        public static long findResult(long divLimit)
        {

            long triangularNum = 0;

            for (long i = 1;true; i++)
            {

                triangularNum += i;

                Console.Write(triangularNum);

                if (countDivisorNums(triangularNum) > divLimit)
                {

                    return triangularNum;

                }

            }

            return -1;

        }

        public static int countDivisorNums(long x)
        {

            int counter = 0;

            for (long i = 1; i <= x; i++)
            {


                if (x % i == 0)
                {

                    counter++;

                }


            }

            Console.Write(" ," + counter + "\n");

            return counter;

        }
    }
}
