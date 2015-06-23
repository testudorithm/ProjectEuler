using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_5
    {
        private const long bigLimit = 99999999999L;

        private const int smallLimit = 20;



        public static int resultControl(){

            



            for(int i = 1; i <= bigLimit; i++){



                if (control (i))

                    return i;



            }



            return -1;



        }



        public static bool control(int num){





            for(int i = 1; i <= smallLimit; i++){



                if (num % i != 0)

                    return false;



            }



            return true;



        }
    }
}
