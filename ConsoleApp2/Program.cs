/*You might know some pretty large perfect squares. But what about the NEXT one?

Complete the findNextSquare method that finds the next integral perfect square after the one passed as a parameter.
Recall that an integral perfect square is an integer n such that sqrt(n) is also an integer.

If the parameter is itself not a perfect square, than -1 should be returned. You may assume the parameter is positive.

Examples:

findNextSquare(121) --> returns 144 // 11x11 = 12 ==> 12*12 = 144 and so on..
findNextSquare(625) --> returns 676
findNextSquare(114) --> returns -1 since 114 is not a perfect */





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Kata
    {
       
        public static long FindNextSquare(long num)
        {


            long somethingLong = 0;



            while (num >= 0)
            {
                double somethingDouble = Math.Sqrt(num);
                bool isInt = somethingDouble == (int)somethingDouble;

                //Sqrt(num) is not an integer
                if (isInt == false)
                {
                    somethingLong=-1;
                    break;

                }

                else if (isInt == true)
                {


                    //Sqrt(num) is an integer

                    //11
                    somethingDouble = Math.Pow(somethingDouble + 1, 2); //(11+1)^2
                    somethingLong = (long)somethingDouble;
                    break;

                }



            }


            while (num < 0)  //if num < 0 
            {

                Console.WriteLine(-1);
                break;
            }


            


            return somethingLong;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindNextSquare(144));

        }
    }
}



