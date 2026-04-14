using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_ForLoopTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Task 1 :  Analyze an Array with Loops*/
            /*int[] x = new int[] { 10, 15, 22, 7, 8, 13, 30 };
            int sum = 0;
            int even = 0;
            int odd = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];    
                if(x[i]%2==0)
                {
                    even++;
                }
                else { odd++;}
            }

            Console.WriteLine("Sum: "+sum);
            Console.WriteLine("Even count: "+even);
            Console.WriteLine("Odd count: "+odd);
            double avg = Convert.ToDouble(sum) / x.Length;
            Console.WriteLine("Average: " +avg);
            int count = 0;
            foreach (int i in x)
            {
                if (i>avg) { count++; }
            }



            int[] y=new int[count];
            int n = 0;
            foreach (int i in x)
            {
                if (i > avg) {
                    y[n]= i; 
                    n++;
                }
            }

            Console.WriteLine("Filtered array: " + string.Join(", ", y));*/

            //t2
            /* int[] x = { 12, 45, 7, 23, 56, 19 };
             int max = x[0];
             for (int i = 1; i < x.Length; i++)
             {
                 if (x[i] > max)
                     max = x[i]; 

             }
             Console.WriteLine(max);*/

            //t3
            /*  for(int i = 1; i <= 10; i++)
              {

                  if (i % 2 == 0) Console.WriteLine( i+ " is an Even Number ");
                  else
                  {
                      Console.WriteLine(i);
                  }
              }*/

            //t4
            /* try {
                 Console.Write("Enter your full name: ");
                 string name = Console.ReadLine();

                 Console.Write("Enter your age: ");
                 int age = Convert.ToInt32(Console.ReadLine());

                 Console.Write("Enter your height: ");
                 double height = Convert.ToDouble(Console.ReadLine());

                 Console.Write("Are you employed? (true/false) : ");
                 bool isEmployed = Convert.ToBoolean(Console.ReadLine());

                 Console.WriteLine("--- User Profile ---");
                 Console.WriteLine($"Name: {name}");
                 Console.WriteLine($"Age: {age}");
                 Console.WriteLine($"Height: {height}");
                 Console.WriteLine($"Emplyed: {isEmployed}");
             }
             catch {

                 Console.WriteLine("Sorry you entered a wrong data format ,please try again");
             }*/

            //t5
            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            string lowerName=name.ToLower();
            string upperName=name.ToUpper();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name :\t" + upperName);
            Console.WriteLine($"Age :\t{age}");
            Console.WriteLine("First letter of your name is : " + upperName[0]);
            Console.WriteLine("Last letter of your name is : " + upperName[name.Length-1]);*/

            //t6
            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0) { continue; }
                else if(i == 8) { break; }
                else { Console.WriteLine(i); }
            
            }


            Console.WriteLine("Dana");

            Console.WriteLine("Dana");


        }
    }
}
