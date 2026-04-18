using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4__c_
{
    internal class Program

    {
        static void sumAvg(int[] nums)
        {
            double sum = 0;
            double avg = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            avg = sum / nums.Length;
            Console.WriteLine("the sum of 10 no is : "+ sum);
            Console.WriteLine("the avg  is : "+ avg);
        }

        static void cubeOf(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine("Number is : " + i + " and cube of it is: " + Math.Pow(i, 3));
            }
        }

        static int[] getYears(int[] nums)
        {
            List<int> years = new List<int>();
            foreach (int num in nums)
            {
                if (num > 1950) {  years.Add(num); }
            }
            return years.ToArray();
        }
        static int inDays(int x)
        {
            return x * 365;
        }
        static int animals(int chickens, int cows, int pigs)
        {
            if (chickens < 0 || cows < 0 || pigs < 0)
            {
                Console.WriteLine("Invalid ");
                return 0;
            }

            return (chickens * 2) + (cows *4)+ (pigs * 4);
        }

        static string login(string username, string password)
        {
            string[] users = { "dana", "admin" };
            string[] passwords = { "123", "admin123" };

            for (int i = 0; i < users.Length; i++)
            {
                if (username == users[i] && password == passwords[i])
                {
                    return "Pass";
                }
            }

            return "Failed";
        }

        static double power(double x,double y)
        {
            return Math.Pow(x,y);
        }

        static string leap(int x)
        {
            if(x>1900 && x <= 2024)
            {
                if (x % 4 == 0)
                    return "it's a leap year";
                else
                    return "it's not a leap year";
            }
            else
            {
                return "invalid year";
            }
        }

        static bool IsPrime(int number)
        {
            
            if (number <= 1) return false;
            
            if (number % 2 == 0) return false;

            for (int i = 3; i <= number; i += 2)
            {   if (number == i) continue;
                if (number % i == 0) return false;
            }

            return true;
        }
        static int numOdWords(string s)
        {
            string[] words = s.Split(' ');
            return words.Length;
        }
        static void Main(string[] args)
        {
            //t1
            /* int[] arr = { 2, 1, 6, 4, 8, 9, 10, 10, 3, 2 };
             sumAvg(arr);*/

            //t2
            /* cubeOf(5);*/

            //t3
            /*  int[] x = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
              Console.WriteLine(string.Join(",", getYears(x)));*/

            //t4
            /* Console.WriteLine(inDays(1));*/

            //t5
            //Console.WriteLine(animals(2, 3, 5));

            //t6
            /*Console.WriteLine(login("dana","123"));
            Console.WriteLine(login("sara","123"));*/

            //t7
            /* Console.WriteLine(power(5,3));*/

            /* //t8
             Console.WriteLine(leap(1800));
             Console.WriteLine(leap(2024));
             Console.WriteLine(leap(2021));*/

            //t9
            /*  Console.WriteLine(IsPrime(10));
              Console.WriteLine(IsPrime(7));*/

            //t10
        /*    string s = "hello";
            string s2 = "hello world";
            string s3 = "hello world i am dana";
            Console.WriteLine(numOdWords(s));
            Console.WriteLine(numOdWords(s2));
            Console.WriteLine(numOdWords(s3));*/




        }
    }
}
