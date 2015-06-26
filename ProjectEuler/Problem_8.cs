using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_8
    {
        private const int range = 13;
        private static int[,] matrix = new int[20, 50] { { 7, 3, 1, 6, 7, 1, 7, 6, 5, 3, 1, 3, 3, 0, 6, 2, 4, 9, 1, 9, 2, 2, 5, 1, 1, 9, 6, 7, 4, 4, 2, 6, 5, 7, 4, 7, 4, 2, 3, 5, 5, 3, 4, 9, 1, 9, 4, 9, 3, 4 }, { 9, 6, 9, 8, 3, 5, 2, 0, 3, 1, 2, 7, 7, 4, 5, 0, 6, 3, 2, 6, 2, 3, 9, 5, 7, 8, 3, 1, 8, 0, 1, 6, 9, 8, 4, 8, 0, 1, 8, 6, 9, 4, 7, 8, 8, 5, 1, 8, 4, 3 }, { 8, 5, 8, 6, 1, 5, 6, 0, 7, 8, 9, 1, 1, 2, 9, 4, 9, 4, 9, 5, 4, 5, 9, 5, 0, 1, 7, 3, 7, 9, 5, 8, 3, 3, 1, 9, 5, 2, 8, 5, 3, 2, 0, 8, 8, 0, 5, 5, 1, 1 }, { 1, 2, 5, 4, 0, 6, 9, 8, 7, 4, 7, 1, 5, 8, 5, 2, 3, 8, 6, 3, 0, 5, 0, 7, 1, 5, 6, 9, 3, 2, 9, 0, 9, 6, 3, 2, 9, 5, 2, 2, 7, 4, 4, 3, 0, 4, 3, 5, 5, 7 }, { 6, 6, 8, 9, 6, 6, 4, 8, 9, 5, 0, 4, 4, 5, 2, 4, 4, 5, 2, 3, 1, 6, 1, 7, 3, 1, 8, 5, 6, 4, 0, 3, 0, 9, 8, 7, 1, 1, 1, 2, 1, 7, 2, 2, 3, 8, 3, 1, 1, 3 }, { 6, 2, 2, 2, 9, 8, 9, 3, 4, 2, 3, 3, 8, 0, 3, 0, 8, 1, 3, 5, 3, 3, 6, 2, 7, 6, 6, 1, 4, 2, 8, 2, 8, 0, 6, 4, 4, 4, 4, 8, 6, 6, 4, 5, 2, 3, 8, 7, 4, 9 }, { 3, 0, 3, 5, 8, 9, 0, 7, 2, 9, 6, 2, 9, 0, 4, 9, 1, 5, 6, 0, 4, 4, 0, 7, 7, 2, 3, 9, 0, 7, 1, 3, 8, 1, 0, 5, 1, 5, 8, 5, 9, 3, 0, 7, 9, 6, 0, 8, 6, 6 }, { 7, 0, 1, 7, 2, 4, 2, 7, 1, 2, 1, 8, 8, 3, 9, 9, 8, 7, 9, 7, 9, 0, 8, 7, 9, 2, 2, 7, 4, 9, 2, 1, 9, 0, 1, 6, 9, 9, 7, 2, 0, 8, 8, 8, 0, 9, 3, 7, 7, 6 }, { 6, 5, 7, 2, 7, 3, 3, 3, 0, 0, 1, 0, 5, 3, 3, 6, 7, 8, 8, 1, 2, 2, 0, 2, 3, 5, 4, 2, 1, 8, 0, 9, 7, 5, 1, 2, 5, 4, 5, 4, 0, 5, 9, 4, 7, 5, 2, 2, 4, 3 }, { 5, 2, 5, 8, 4, 9, 0, 7, 7, 1, 1, 6, 7, 0, 5, 5, 6, 0, 1, 3, 6, 0, 4, 8, 3, 9, 5, 8, 6, 4, 4, 6, 7, 0, 6, 3, 2, 4, 4, 1, 5, 7, 2, 2, 1, 5, 5, 3, 9, 7 }, { 5, 3, 6, 9, 7, 8, 1, 7, 9, 7, 7, 8, 4, 6, 1, 7, 4, 0, 6, 4, 9, 5, 5, 1, 4, 9, 2, 9, 0, 8, 6, 2, 5, 6, 9, 3, 2, 1, 9, 7, 8, 4, 6, 8, 6, 2, 2, 4, 8, 2 }, { 8, 3, 9, 7, 2, 2, 4, 1, 3, 7, 5, 6, 5, 7, 0, 5, 6, 0, 5, 7, 4, 9, 0, 2, 6, 1, 4, 0, 7, 9, 7, 2, 9, 6, 8, 6, 5, 2, 4, 1, 4, 5, 3, 5, 1, 0, 0, 4, 7, 4 }, { 8, 2, 1, 6, 6, 3, 7, 0, 4, 8, 4, 4, 0, 3, 1, 9, 9, 8, 9, 0, 0, 0, 8, 8, 9, 5, 2, 4, 3, 4, 5, 0, 6, 5, 8, 5, 4, 1, 2, 2, 7, 5, 8, 8, 6, 6, 6, 8, 8, 1 }, { 1, 6, 4, 2, 7, 1, 7, 1, 4, 7, 9, 9, 2, 4, 4, 4, 2, 9, 2, 8, 2, 3, 0, 8, 6, 3, 4, 6, 5, 6, 7, 4, 8, 1, 3, 9, 1, 9, 1, 2, 3, 1, 6, 2, 8, 2, 4, 5, 8, 6 }, { 1, 7, 8, 6, 6, 4, 5, 8, 3, 5, 9, 1, 2, 4, 5, 6, 6, 5, 2, 9, 4, 7, 6, 5, 4, 5, 6, 8, 2, 8, 4, 8, 9, 1, 2, 8, 8, 3, 1, 4, 2, 6, 0, 7, 6, 9, 0, 0, 4, 2 }, { 2, 4, 2, 1, 9, 0, 2, 2, 6, 7, 1, 0, 5, 5, 6, 2, 6, 3, 2, 1, 1, 1, 1, 1, 0, 9, 3, 7, 0, 5, 4, 4, 2, 1, 7, 5, 0, 6, 9, 4, 1, 6, 5, 8, 9, 6, 0, 4, 0, 8 }, { 0, 7, 1, 9, 8, 4, 0, 3, 8, 5, 0, 9, 6, 2, 4, 5, 5, 4, 4, 4, 3, 6, 2, 9, 8, 1, 2, 3, 0, 9, 8, 7, 8, 7, 9, 9, 2, 7, 2, 4, 4, 2, 8, 4, 9, 0, 9, 1, 8, 8 }, { 8, 4, 5, 8, 0, 1, 5, 6, 1, 6, 6, 0, 9, 7, 9, 1, 9, 1, 3, 3, 8, 7, 5, 4, 9, 9, 2, 0, 0, 5, 2, 4, 0, 6, 3, 6, 8, 9, 9, 1, 2, 5, 6, 0, 7, 1, 7, 6, 0, 6 }, { 0, 5, 8, 8, 6, 1, 1, 6, 4, 6, 7, 1, 0, 9, 4, 0, 5, 0, 7, 7, 5, 4, 1, 0, 0, 2, 2, 5, 6, 9, 8, 3, 1, 5, 5, 2, 0, 0, 0, 5, 5, 9, 3, 5, 7, 2, 9, 7, 2, 5 }, { 7, 1, 6, 3, 6, 2, 6, 9, 5, 6, 1, 8, 8, 2, 6, 7, 0, 4, 2, 8, 2, 5, 2, 4, 8, 3, 6, 0, 0, 8, 2, 3, 2, 5, 7, 5, 3, 0, 4, 2, 0, 7, 5, 2, 9, 6, 3, 4, 5, 0 } };
        private static string marixStr = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
        private static long[] maxValDirects = new long[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static string[] maxProductsDirects = new string[8];



        public static void smartSol()
        {


            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    long[] tempArr = direct_1(i, j);


                    if (tempArr[0] != -1 && tempArr[range] > maxValDirects[0])
                    {


                        maxValDirects[0] = tempArr[range];
                        maxProductsDirects[0] = getProducts(tempArr);
                    }

                    long[] tempArr2 = direct_2(i, j);

                    if (tempArr2[0] != -1 && tempArr2[range] > maxValDirects[1])
                    {


                        maxValDirects[1] = tempArr2[range];
                        maxProductsDirects[1] = getProducts(tempArr2);
                    }

                    long[] tempArr3 = direct_3(i, j);

                    if (tempArr3[0] != -1 && tempArr3[range] > maxValDirects[2])
                    {


                        maxValDirects[2] = tempArr3[range];
                        maxProductsDirects[2] = getProducts(tempArr3);
                    }

                    long[] tempArr4 = direct_4(i, j);

                    if (tempArr4[0] != -1 && tempArr4[range] > maxValDirects[3])
                    {


                        maxValDirects[3] = tempArr4[range];
                        maxProductsDirects[3] = getProducts(tempArr4);
                    }

                    long[] tempArr5 = direct_5(i, j);

                    if (tempArr5[0] != -1 && tempArr5[range] > maxValDirects[4])
                    {


                        maxValDirects[4] = tempArr5[range];
                        maxProductsDirects[4] = getProducts(tempArr5);
                    }

                    long[] tempArr6 = direct_6(i, j);

                    if (tempArr6[0] != -1 && tempArr6[range] > maxValDirects[5])
                    {


                        maxValDirects[5] = tempArr6[range];
                        maxProductsDirects[5] = getProducts(tempArr6);
                    }

                    long[] tempArr7 = direct_7(i, j);

                    if (tempArr7[0] != -1 && tempArr7[range] > maxValDirects[6])
                    {


                        maxValDirects[6] = tempArr7[range];
                        maxProductsDirects[6] = getProducts(tempArr7);
                    }

                    long[] tempArr8 = direct_8(i, j);

                    if (tempArr8[0] != -1 && tempArr8[range] > maxValDirects[7])
                    {


                        maxValDirects[7] = tempArr8[range];
                        maxProductsDirects[7] = getProducts(tempArr8);
                    }


                }

            }


            long maxValue = maxValDirects.Max();
            string maxProduct = maxProductsDirects[getIndex(maxValDirects, maxValue)];

            Console.WriteLine(maxProduct + ", " + maxValue);


        }

        public static void stupidSol()
        {

            long maxx = 0;


            for (int i = 0; i < 1000; i++)
            {

                long tempTotal = 1;
                try
                {
                    string subTr = marixStr.Substring(i, 13);

                    foreach (char x in subTr)
                    {

                        tempTotal *= Convert.ToInt32(x + "");

                    }

                    if (tempTotal > maxx)
                        maxx = tempTotal;

                }
                catch (Exception ex)
                {

                    break;

                }

            }

            Console.WriteLine(maxx);

        }

        public static int getIndex(long[] x, long val)
        {

            for (int i = 0; i < x.Length; i++)
            {

                if (x[i] == val)
                    return i;

            }
            return -1;
        }

        public static string getProducts(long[] x)
        {

            string prod = "";

            for (int i = 0; i < x.Length - 1; i++)
            {

                prod += x[i] + "";

            }

            return prod;

        }

        public static long[] direct_1(int i, int j)
        {

            long total = 1;
            long[] values = new long[range + 1];
            values[0] = -1;

            for (int c = 0; c < range; c++)
            {

                try
                {

                    values[c] = matrix[i - c, j];
                    total *= matrix[i - c, j];

                }
                catch (Exception ex)
                {

                    values[0] = -1;

                    return values;

                }

            }

            if (values[range - 1] != -1)
            {
                values[range] = total;
            }

            return values;

        }

        public static long[] direct_2(int i, int j)
        {

            long total = 1;
            long[] values = new long[range + 1];
            values[0] = -1;

            for (int c = 0; c < range; c++)
            {

                try
                {

                    values[c] = matrix[i - c, j + c];
                    total *= matrix[i - c, j + c];

                }
                catch (Exception ex)
                {

                    values[0] = -1;

                    return values;

                }

            }

            if (values[range - 1] != -1)
            {
                values[range] = total;
            }

            return values;

        }

        public static long[] direct_3(int i, int j)
        {

            long total = 1;
            long[] values = new long[range + 1];
            values[0] = -1;

            for (int c = 0; c < range; c++)
            {

                try
                {

                    values[c] = matrix[i, j + c];
                    total *= matrix[i, j + c];

                }
                catch (Exception ex)
                {

                    values[0] = -1;

                    return values;

                }

            }

            if (values[range - 1] != -1)
            {
                values[range] = total;
            }

            return values;

        }

        public static long[] direct_4(int i, int j)
        {

            long total = 1;
            long[] values = new long[range + 1];
            values[0] = -1;

            for (int c = 0; c < range; c++)
            {

                try
                {

                    values[c] = matrix[i + c, j + c];
                    total *= matrix[i + c, j + c];

                }
                catch (Exception ex)
                {

                    values[0] = -1;

                    return values;

                }

            }

            if (values[range - 1] != -1)
            {
                values[range] = total;
            }

            return values;

        }

        public static long[] direct_5(int i, int j)
        {

            long total = 1;
            long[] values = new long[range + 1];
            values[0] = -1;

            for (int c = 0; c < range; c++)
            {

                try
                {

                    values[c] = matrix[i + c, j];
                    total *= matrix[i + c, j];

                }
                catch (Exception ex)
                {

                    values[0] = -1;

                    return values;

                }

            }

            if (values[range - 1] != -1)
            {
                values[range] = total;
            }

            return values;

        }

        public static long[] direct_6(int i, int j)
        {

            long total = 1;
            long[] values = new long[range + 1];
            values[0] = -1;

            for (int c = 0; c < range; c++)
            {

                try
                {

                    values[c] = matrix[i + c, j - c];
                    total *= matrix[i + c, j - c];

                }
                catch (Exception ex)
                {

                    values[0] = -1;

                    return values;

                }

            }

            if (values[range - 1] != -1)
            {
                values[range] = total;
            }

            return values;

        }

        public static long[] direct_7(int i, int j)
        {

            long total = 1;
            long[] values = new long[range + 1];
            values[0] = -1;

            for (int c = 0; c < range; c++)
            {

                try
                {

                    values[c] = matrix[i, j + c];
                    total *= matrix[i, j + c];

                }
                catch (Exception ex)
                {

                    values[0] = -1;

                    return values;

                }

            }

            if (values[range - 1] != -1)
            {
                values[range] = total;
            }

            return values;

        }

        public static long[] direct_8(int i, int j)
        {

            long total = 1;
            long[] values = new long[range + 1];
            values[0] = -1;

            for (int c = 0; c < range; c++)
            {

                try
                {

                    values[c] = matrix[i - c, j - c];
                    total *= matrix[i - c, j - c];

                }
                catch (Exception ex)
                {

                    values[0] = -1;

                    return values;

                }

            }

            if (values[range - 1] != -1)
            {
                values[range] = total;
            }

            return values;

        }  
    }
}
