using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem_1
    {
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter a number : ");

			try{

				int inputNum = Convert.ToInt32(Console.ReadLine ());

                Console.WriteLine("First Problem's result : " + Problem_1.findSum(inputNum));

				//1000 -> 233168

			}catch(Exception ex){

				Console.WriteLine ("Error, try again! " + ex.Message);

			}

		}

		public static int findSum(int num){

			int sum = 0;

			for(int i = 0; i < num; i++){

				if (i % 3 == 0 || i % 5 == 0) {

					sum += i;

				}

			}

			return sum;

		}
    }
}
