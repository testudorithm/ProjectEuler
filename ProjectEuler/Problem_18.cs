using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_18
    {
        public static string matrixStr = "75\n95 64\n17 47 82\n18 35 87 10\n20 04 82 47 65\n19 01 23 75 03 34\n88 02 77 73 07 63 67\n99 65 04 28 06 16 70 92\n41 41 26 56 83 40 80 70 33\n41 48 72 33 47 32 37 16 94 29\n53 71 44 65 25 43 91 52 97 51 14\n70 11 33 28 77 73 17 78 39 68 17 57\n91 71 52 38 17 14 91 43 58 50 27 29 48\n63 66 04 68 89 53 67 30 73 16 69 87 40 31\n04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";
        public static int[,] m;

        //public static void Main(string[] args)
        //{


        //    Console.WriteLine(findResult());
        //}

        public static int findResult()
        {

            prepareMatrix(matrixStr);

            int result = 0;

            for (int i = 0; i < m.GetLength(0); i++)
            {

                for (int j = 0; j < (m.GetLength(1) * 2) - 1; j++)
                {

                    if (i >= m.GetLength(0) - 1)
                    {

                        return result;

                    }

                    if (m[i, j] > 0)
                    {



                        int[] nextPoint = getNextLocation(i, j);

                        if (i == 0)
                        {

                            result += m[i, j] + nextPoint[0];

                        }
                        else
                        {

                            result += nextPoint[0];

                        }


                        i = nextPoint[1];
                        j = nextPoint[2] - 1;

                    }

                }

            }

            return -1;

        }

        public static int[] getNextLocation(int i, int j)
        {//Rules, bu kısmı büyütmek gerekiyor.. problem 67 icin gerekli, su an 2li alt dallara bakıyo 13lu falan lazım..

            int[,] result = new int[4, 3];

            if (i + 2 < m.GetLength(0))
            {

                result[0, 0] = m[i + 1, j - 1] + m[i + 2, j - 2];
                result[0, 1] = i + 2;
                result[0, 2] = j - 2;

                result[1, 0] = m[i + 1, j + 1] + m[i + 2, j + 2];
                result[1, 1] = i + 2;
                result[1, 2] = j + 2;

                result[2, 0] = m[i + 1, j - 1] + m[i + 2, j];
                result[2, 1] = i + 2;
                result[2, 2] = j;

                result[3, 0] = m[i + 1, j + 1] + m[i + 2, j];
                result[3, 1] = i + 2;
                result[3, 2] = j;

            }
            else
            {

                result[0, 0] = m[i + 1, j - 1];
                result[0, 1] = i + 1;
                result[0, 2] = j - 1;

                result[1, 0] = m[i + 1, j + 1];
                result[1, 1] = i + 1;
                result[1, 2] = j + 1;

                result[2, 0] = m[i + 1, j - 1];
                result[2, 1] = i + 1;
                result[2, 2] = j - 1;

                result[3, 0] = m[i + 1, j + 1];
                result[3, 1] = i + 1;
                result[3, 2] = j + 1;

            }

            int maxRes = 0;
            int index = 0;

            for (int i_ = 0; i_ < result.GetLength(0); i_++)
            {

                if (result[i_, 0] > maxRes)
                {
                    maxRes = result[i_, 0];
                    index = i_;
                }

            }

            int[] resultArr = { result[index, 0], result[index, 1], result[index, 2] };

            return resultArr;

        }

        public static void prepareMatrix(string x)
        {

            string[] tempRows = matrixStr.Split('\n');
            int len = tempRows.Length;

            m = new int[len, (len * 2) - 1];

            for (int i = 0; i < len; i++)
            {

                if (i == 0)
                {

                    m[0, len - 1] = Convert.ToInt32(tempRows[0]);

                }
                else
                {

                    string[] tempCols = tempRows[i].Split(' ');
                    int counter = 0;
                    int colLen = (len * 2) - 1;

                    for (int j = 0; j < colLen; j++)
                    {


                        if ((i - 1 >= 0 && j - 1 >= 0 && m[i - 1, j - 1] > 0) || (i - 1 >= 0 && j + 1 < colLen && m[i - 1, j + 1] > 0))
                        {

                            m[i, j] = Convert.ToInt32(tempCols[counter]);
                            counter++;

                        }


                    }

                }
            }

        }
    }
}
