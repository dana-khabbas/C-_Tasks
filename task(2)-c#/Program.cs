using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace task_2__c_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //t1
            /* int x=Convert.ToInt32(  Console.ReadLine());
             int y=Convert.ToInt32(  Console.ReadLine());
               Console.WriteLine(x>y?y:x);*/

            //t2
            /* int x = Convert.ToInt32(Console.ReadLine());
             if(x>=0) {
                 Console.WriteLine("+");
             }
             else { Console.WriteLine("-"); }*/

            //t3
            /* int[] ints = new int[3];
             for (int i = 0; i < ints.Length; i++)
             {
                 ints[i] =Convert.ToInt32( Console.ReadLine());
             }
             var sortedNumbers = ints.OrderBy(n => n);
             Console.WriteLine(string.Join(", ", sortedNumbers));*/

            //t4
            /* int[] ints = new int[5];
             for (int i = 0; i < ints.Length; i++)
             {
                 ints[i] = Convert.ToInt32(Console.ReadLine());
             }
             int max=ints.Max();
             Console.WriteLine(max);*/

            //t5
            /* int x = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(x*0.62);*/

            //t6
            /*int hour = Convert.ToInt32(Console.ReadLine());
            int minut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((hour * 60) + (minut));*/

            //t7
            /* int minut = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine((minut / 60) + " Hours, " + (minut % 60) + " Minutes");*/

            //t8
            /* string[] sentences ={"Hello I'm Dana",
              "I'm 23 years old",
             "I love programming",
             "This is  long sentence ",
             "Short "
             };
             foreach (string sentence in sentences) {
                 if (sentence.Length > 40)
                 {
                     Console.WriteLine(sentence.Substring(0,40));
                 }
                 else
                 {
                     Console.WriteLine(sentence.PadLeft(40));
                 }

             }*/

            //t9
           /* string[] words = { "one", "two", "three", "four" };
            foreach (string word in words)
            {
                if (word.Length % 2 == 0)
                {
                    Console.WriteLine(word);
                }

                else {
                    string reversed = new string(word.Reverse().ToArray());
                    Console.WriteLine(reversed);
                }

            }*/

        }
    }
}
