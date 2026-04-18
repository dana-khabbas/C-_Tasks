using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5__c_
{   public class MyClass
    {
        public MyClass() {
            Console.WriteLine("MyClass class has initialized!");
        }
        public MyClass(string name)
        {
            Console.WriteLine("Hello All, I am " + name);
        }
    }

    public class Factorial
    {
        public int calculate(int n)
        {

            int result = 1;

            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }

    public class Order
    {
        public int[] orderArray(int[] n)
        {
            Array.Sort(n);
            return n;
        }
    }
    internal class Program

    {
        static void dateDiff(DateTime date1, DateTime date2)
        {
            if (date1 < date2)
            {
                DateTime temp = date1;
                date1 = date2;
                date2 = temp;
            }

            TimeSpan diff = date1 - date2;

            int result = diff.Days;

            int years = result / 365;
            int months = (result % 365) / 30;
            int days = (result % 365) % 30;

            Console.WriteLine($"Difference: {years} years, {months} months, {days} days");

        }
        static void stringToDate(string s)

        {
            string result = "";
            if (s.Contains("-"))
            {
                string[] arr = s.Split('-');
                List<string> list = new List<string>();
                for(int i = arr.Length-1; i >=0 ; i--)
                {
                    list.Add(arr[i]);
                }
                 result=string.Join("-", list);
            }
            else
            {
                string[] arr = s.Split('/');
                List<string> list = new List<string>();
                list.Add(arr[1]);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == 1) continue;
                    list.Add(arr[i]);
                }
               result  = string.Join("/", list);
            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            //t1
            /* MyClass myClass = new MyClass();*/

            //t2
            /* MyClass myClass1 = new MyClass("Scott");*/

            //t3
            /* Factorial f= new Factorial();
             Console.WriteLine(f.calculate(5));*/

            //t4
            /* int[] x = {  11, -2, 4, 35, 0, 8, -9 };
             Order o = new Order();
             string s=string.Join(",", o.orderArray(x));
             Console.WriteLine(s);*/

            //t5
            /*  DateTime d1 = new DateTime(1981, 11, 03);
              DateTime d2 = new DateTime(2013, 09, 04);
              dateDiff(d1, d2);*/

            //t6
            string dateString = "2004-08-12";
            string dateString2 = "12/08/2004";
            stringToDate(dateString);
            stringToDate(dateString2);
        }
    }
}
