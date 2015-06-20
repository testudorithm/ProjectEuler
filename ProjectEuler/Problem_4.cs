using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_4
    {

        public static int[] getLargestTwo3Digits() {

            int[] result = new int[2];

            for (int i = 999999; i >= 10000; i--)
            {

                if (isPalindrome(i)) {

                    for (int j = 100; j < 1000; j++) {
                    
                        if(i % j == 0 && (i / j).ToString().Length == 3){

                            result[0] = j;
                            result[1] = (i / j);

                            Console.WriteLine("Palindorme number: " + i);

                            return result;

                        }

                    }

                }

            }

            return result;

        }


        public static bool isPalindrome(int x){

            string temp = x.ToString();

            if (temp == Reverse(temp))
                return true;

            return false;

        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
