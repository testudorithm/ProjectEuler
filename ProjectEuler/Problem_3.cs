using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_3
    {
        //public static void Main(string[] args)
        //{
        //    long number = 600851475143L;

        //    Console.WriteLine("Result: " + countResArr(number));

        //    Console.ReadLine();

        //}

        public static string countResArr(long x)
        {

            string result = "";

            for (int i = 2; i <= x; i++)
            {

                if (x == 1)
                {

                    break;

                }

                if (x % i == 0 && isPrimeNum(i))
                {

                    result += i + " ";
                    x /= i;

                }

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
