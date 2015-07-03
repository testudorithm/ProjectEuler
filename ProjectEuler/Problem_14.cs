using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_14
    {

        public static int findResult(int start) {

            int maxResult = 0;
            int number = 0;

            for (int i = start, counter; i >= 0; i--) {
                counter = 1;

                for (long j = (long)i; j > 1;) {

                    if (j % 2 == 0) {

                        j = j / 2;

                    } else {

                        j = (3 * j) + 1;
                        
                    }

                    counter++;

                }

                if (counter > maxResult)
                {
                    maxResult = counter;
                    number = i;

                    Console.WriteLine("new king: " + maxResult + ", " + number);

                }

            }

            return number;

        }

    }
}
