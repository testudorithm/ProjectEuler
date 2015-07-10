using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_19
    {
      public static int[,] months = new int[12, 2] { {31,-1}, {28,29}, {31, -1}, {30, -1}, {31, -1}, {30,-1}, {31, -1}, {31, -1}, {30,-1}, {31, -1}, {30, -1}, {31, -1}};
      public static string[] days = new string[7] { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };
        public static int findResult() {

            int totalDays = 0;
            int lastDayNum = 1;
            int dayCounter = 0;
            int currentDays = 0;

            for(int i = 1901; i <= 2000; i++){

                for (int j = 0; j < 12; j++ )
                {

                    if (j + 1 == 2 && i > 1900 && i % 4 == 0) { 
                    
                            totalDays += months[j,1];
                            currentDays = months[j, 1];


                    } else {
                    
                        totalDays += months[j, 0];
                        currentDays = months[j, 0];
                    }

                    lastDayNum += currentDays % 7;

                    if (lastDayNum >= 6)
                        lastDayNum %= 7;

                    if (days[lastDayNum] == "sunday")
                        dayCounter++;

                }

            }

            //countTotalSunday(totalDays)

            return dayCounter;
        }

        public static int countTotalSunday(int x){

            int expectNum = x % 7;
            int totalSunday = (x - expectNum) / 7;

            if (expectNum == 6)
                totalSunday++;

            return totalSunday;
        }

    }
}
