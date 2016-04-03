using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare array and target
            int[] numbers = new int[10];
            int target = 0;
            bool targetFound = false;

            //Set first, mid and last
            int first = 0;
            int mid = 0;
            int last = numbers.Length - 1;

            while (first <= last)
            {
                //Calculate mid
                mid = (first + last) / 2;

                //check if target is mid
                if (target == numbers[mid])
                {
                    Console.WriteLine("Target found at position " + mid.ToString());

                    targetFound = true;

                    //Break out of loop
                    break;
                }
                else if (target < numbers[mid])
                {
                    last = mid - 1;
                }
                else if (target > numbers[mid])
                {
                    first = mid + 1;
                }

            }//End While


            if (!targetFound)
            {
                
            }



        }//End Main
    }
}
