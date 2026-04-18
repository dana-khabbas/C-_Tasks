using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3__c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //t1
            /*string[] ARR = { "1", "7", " 9", "  45" };
            string[] arr2 = { "Str" ,"alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };*/

            //t2
            /*String[] fruits = { "Tomato", "Banana", "Watermelon" };
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == "Banana")
                    Console.WriteLine("banana index is " + i);
                else if (fruits[i] == "Tomato")
                    Console.WriteLine("tomato index is " + i);
                else
                    continue;
            }*/

            //t3
            /*  string[] food = { "chips", "choco", "tea", "coffee", "shawerma" };
              string[] sports = { "hiking", "swimming", "basketBall" };
              string[] Movies = { "invisibleGuest", "homeAlone", "allHerFault" ,"orientExpress"};
              foreach (string s in food)
              {
                  Console.WriteLine(s);
              }
              for (int i = 0; i < sports.Length; i++)
              {
                  Console.WriteLine(sports[i]);
              }
              foreach (string s in Movies)
              {
                  Console.WriteLine(s);
              }*/

            //t4

            /* string num = Console.ReadLine();

             string[] numArr = num.Split(',');

             int num1 = int.Parse(numArr[0]);
             int num2 = int.Parse(numArr[1]);
             int num3 = int.Parse(numArr[2]);

             int sum = num1 + num2 + num3;

             Console.WriteLine(sum);*/

            //t5
            /* int n = 10;
             int sum = 0;
             Console.WriteLine("the odd numbers are : ");
             for (int i = 0; i < n; i++)
             {
                 if (i %2!= 0)
                 {
                     Console.Write(i+" ");
                     sum += i;
                 }
             }
             Console.WriteLine();
             Console.WriteLine("The sum of odd numbers is " + sum);*/

            //t6
            /* int n = 3;
             for (int i = 1; i <= n; i++)
             {
                 int space = n - i;
                 for (int j = 1; j <= space; j++)
                 {
                     Console.Write(" ");
                 }
                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write("* ");
                 }
                 Console.WriteLine();

             }*/


            //t7
            /*int n = 5;
            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                int space = n - i;
                for (int j = 1; j <= space; j++)
                {
                    Console.Write(" ");
                }
               
                for (int j=1; j<= i; j++)
                {
                    Console.Write(x+" ");
                    x++;
                }
                Console.WriteLine();

            }*/

            
        }
    }
}
