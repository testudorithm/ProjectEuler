using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_17
    {
        public static int findResult(int limit) {

            int totalSum = 0;

            for (int i = 1; i <= limit; i++){
            
                if(i < 100){

                    totalSum += getDigitsStr(i).Length;

                    Console.WriteLine(getDigitsStr(i));

                }
                else if (i >= 100 && i < 1000) {

                    totalSum += getDigitsStr((i - (i % 100))/100).Length;

                    if (i % 100 != 0)
                    {
                        totalSum += ("hundredand").Length;
                        totalSum += getDigitsStr(i % 100).Length;

                        Console.WriteLine(getDigitsStr((i - (i % 100)) / 100) + "hundredand" + getDigitsStr(i % 100));
                    }
                    else {

                        totalSum += ("hundred").Length;
                        Console.WriteLine(getDigitsStr((i - (i % 100)) / 100) + "hundred");
                    }

                   
                } else if(i == 1000){

                    totalSum += ("onethousand").Length;

                    Console.WriteLine("onethousand");

                }

            }

            return totalSum;

        }

        public static string[,] strToDigits = new string[20,2]{ { "zero", "" }, {"one", ""}, {"two", "twenty"}, {"three","thirty"}, {"four", "forty"}, {"five", "fifty"}, {"six", "sixty"}, {"seven", "seventy"}, {"eight", "eighty"}, {"nine", "ninety"}, {"ten", ""}, {"eleven", ""}, {"twelve", ""}, {"thirteen", ""}, {"fourteen", ""}, {"fifteen", ""}, {"sixteen", ""}, {"seventeen", ""}, {"eighteen", ""}, {"nineteen", ""} };

        public static string getDigitsStr(int x) {

            try {

                return strToDigits[x, 0];

            }catch(Exception ex){

                if (x % 10 == 0)
                {

                    return strToDigits[((x - (x % 10)) / 10), 1];

                }
                else
                {

                    return strToDigits[((x - (x % 10)) / 10), 1] + strToDigits[x % 10, 0];

                }
            
            }

           

        }
    
    }
}
