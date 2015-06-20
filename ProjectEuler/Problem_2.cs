using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_2
    {
        //public static void Main(string[] args)
        //{

        //    Console.WriteLine("2. Problem's result: " + Problem_2.findSum(4000000));

        //}

        public static int findSum(int limit)
        {
            
            int i = 1, j = 2, sum = 0, mem;

            for (; ; )
            {

                //Console.WriteLine (i);

                if (j >= limit)
                    break;

                if (j % 2 == 0)
                    sum += j;

                mem = j;
                j += i;
                i = mem;

            }

            return sum;

        }
    }
}
