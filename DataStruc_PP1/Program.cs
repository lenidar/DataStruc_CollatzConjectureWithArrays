using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruc_PP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // remake of the collatz conjecture with arrays
            // given a value x
            // if x is a odd number do 3x + 1
            // if x is an even number divide by 2
            // the collatz conjecture terminates if the numbers 4, 2 and 1
            // are repeated at least once

            int[] nums = new int[6];
            Random rnd = new Random();
            int sNum = 5;
            bool repeat = true;

            sNum = rnd.Next(1,100);

            while(repeat)
            {
                //Console.WriteLine(sNum);
                // move the elements
                //for (int x = 0; x < nums.Length - 1; x++)
                //{
                //    nums[x + 1] = nums[x];
                //}
                for (int x = nums.Length - 2; x >= 0; x--)
                {
                    nums[x + 1] = nums[x];
                }

                // add the new element to index 0
                nums[0] = sNum;
                Console.Write(nums[0] + "\t");

                // for debugging purposes display the array
                //foreach (int num in nums)
                //    Console.Write(num + "\t");
                //Console.WriteLine();

                // terminating function
                //if (nums[0] == nums[3])
                //{
                //    if (nums[1] == nums[4])
                //    {
                //        if (nums[2] == nums[5])
                //        {
                //            repeat = false;
                //        }
                //    }
                //}

                repeat = false;
                for(int x = 0; x < 3; x++)
                {
                    if (nums[x] == nums[x + 3])
                    {
                        continue;
                    }
                    else
                    {
                        repeat = true;
                        break;
                    }
                }


                if (sNum % 2 == 0)
                {
                    sNum /= 2;
                }
                else
                {
                    sNum *= 3;
                    sNum++;
                }
                //Console.ReadKey();
            }
            Console.ReadKey();

        }
    }
}
