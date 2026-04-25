using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task____Loops_String_Array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------loops---------------*/
            //t1
            /* for(int i= 1;i<=5;i++)
             {
                 if(i%2==0)
                 {
                     for (int j = i; j >= 1; j--)
                     {
                          Console.Write(j); 
                     }
                 }
                 else
                 {
                     for (int j = 1; j <= 5; j++)
                     {
                         if (j <= i) { Console.Write(j); }
                     }
                 }
                 Console.WriteLine();
             }*/


            //t2
            /*  int x=Convert.ToInt32( Console.ReadLine());


              for (int i = 1; i <= x; i++)
              {
                  int[] arr = new int[x];
                  int counter = 0;

                  for (int j = 1; j <= i; j++)
                  {

                      Console.Write(j);
                      arr[counter] = j;
                      counter++;


                  }
                  for (int k = arr.Length - 1; k >= 0; k--)
                  {   if (arr[k] == 0)
                      { Console.Write(" ");continue; }
                      Console.Write(arr[k]);
                  }
                  Console.WriteLine("");
              }*/

            //t3
            /* int x = Convert.ToInt32(Console.ReadLine());
             for (int i = 1; i <= x; i++)
             {
                 for (int s = 1; s <= x - i; s++)
                 {
                     Console.Write(" ");
                 }

                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write(j);
                 }

                 for (int j = i - 1; j >= 1; j--)
                 {
                     Console.Write(j);
                 }

                 Console.WriteLine();
             }*/

            //t4
            /* int x = Convert.ToInt32(Console.ReadLine());
             for(int i = 1; i <=x; i++) {
                 int counter = 1;
                 for (int j = 1; counter <=i; j++)
                 {   
                     if(j%2== 0)
                     {
                         continue;
                     }
                     Console.Write(j);
                     counter++;

                 }
                 Console.WriteLine();

             }*/
            /* int x = Convert.ToInt32(Console.ReadLine());
             for (int i = 0; i < x; i++)
             {
                for (int j = 0; j <=i; j++)
                 {
                     Console.Write(Math.Pow(2,i));
                 }
                Console.WriteLine();
             }*/



            /* ************************Arrays****************/
            //t3 Split by Value Change
            int[] x = { 1, 1, 2, 2, 3, 1 };

            int current = x[0];
            for (int i = 0; i < x.Length; )
            {
              
                Console.Write("[");
                while (current == x[i]) {
                    Console.Write( x[i]+"," );

                    i++;
                }
                Console.Write("]");
                current = x[i];
                



            }


















        }
    }
}
