using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_1_
{
    internal class Program
    {
        //t1
        static int minutesToSeconds(int minuts)
        {
            return minuts*60;
        }

        //t2
        static int addOne(int x)
        {
            return x+1;
        }

        //t3
        static int firstElement(int[] x) { 
            return x[0]; }

        //t4
        static double triangleArea(double x, int y)
        {
            return ((x / 2) * y);
        }

        //t5
        static ArrayList evenNumberEvenIndex(int[] nums)
        {   ArrayList arrayList = new ArrayList();
            for (int i = 0;i<nums.Length;i++)
            {
                if (i %2== 0)
                {
                    if(nums[i]%2== 0)
                    {
                        arrayList.Add(nums[i]);
                    }
                }
            }
            return arrayList;
        }

        //t6 
        static ArrayList evenIndexOddLength(string[] words)
        {
            ArrayList arrayList = new ArrayList();
            for(int i = 0; i < words.Length; i++)
            {
                if(i%2== 0)
                {
                    if (words[i].Length%2 != 0)
                    {
                        arrayList.Add(words[i]);
                    }
                }
            }
            return arrayList;
        }

        //t7
        static void  powerElementIndex(int[] nums)
        {
        for(int i = 0;i < nums.Length; i++)
            {
                nums[i] =Convert.ToInt32( Math.Pow(nums[i],i));
            }
       
        }

        //t8
        static void multiplication2(int x, int y)
        {
            int x2 = x;
            Console.Write(x + " * " + y + " is ");
            for (int i = 1; i < y; i++)
            {
                x += x2;
            }
            Console.Write(x);
            Console.WriteLine();
        }

        static int multi2(int x, int y)
        {
            for (int i = x;i < y; i++)
            {
                x *= (i + 1);
            }
            return x;
        }

        static double aveArray(int[] nums)
        {
            double sum = 0;
            foreach (int x in nums)
            {
            sum += x;
            }
            return (sum/nums.Length);
        }
        static void Main(string[] args)
        {
            //t1
            //Console.WriteLine(minutesToSeconds(5));

            //t2
            // Console.WriteLine(addOne(1));

            //t3
            /*int[] arr = { 6, 9, 10, 14, };
            Console.WriteLine(firstElement(arr));*/

            //t4
            /* int x = 4;
             int height = 8;
             Console.WriteLine(triangleArea(x, height));*/

            //t5
            /*int[] nums = { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1 };

            ArrayList list = evenNumberEvenIndex(nums);
            foreach (int x in list)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();*/

            //t6
            /* string[] words = { "alex", "mercer", "madrasa", "rashed2", "emad", "hala" };
             ArrayList list = evenIndexOddLength(words);
             foreach (string x in list)
             {
                 Console.Write(x + " ");
             }
             Console.WriteLine();*/

            //t7 
            /*int[] nums = {44, 5, 4, 3, 2, 10};
            powerElementIndex(nums);
            foreach(int i in nums)
            {
                Console.Write(i+" ");
            }*/

            //t8
            // multiplication2(5, 4);

            //t9
            // Console.WriteLine(multi2(3, 6));

            //t10
           /* int[] nums = { 1, 2, 3, 8, 9, 77 };
            Console.WriteLine(aveArray(nums));*/





        }
    }
}
