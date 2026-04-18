using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_2_
{
    internal class Program
    {
        //t1 
        static void dateDiff(DateTime d,DateTime d2)
        {
            //notes for me 
            /*  DateTime → a specific point in time(like: June 14, 2019)
                TimeSpan → how much time between two points*/
            TimeSpan t = d2 - d;
            Console.WriteLine(Math.Abs(t.Days));
        }

        //t2
        static string[] NumInStr(string[] arr)
        {
            List<string> result = new List<string>();

            foreach (string s in arr)
            {
                foreach (char c in s)
                {
                    if (char.IsDigit(c))
                    {
                        result.Add(s);
                        break; 
                    }
                }
            }

            return result.ToArray();
        }

        //t4
        static bool pandigitalNum(long x)
        {
            List<int> l = new List<int>();
            while (x > 0)
            {
                int z =Convert.ToInt32( (x % 10));
                l.Add(z);
                x = x / 10;
            }
            int c = 0;
           for (int i = 0; i <10; i++)
            {
                if (l.Contains(i))
                {
                    c++;
                }
            }
            return c == 10 ? true:false ;
        }
        static void Main(string[] args)
        {
            //t1
            /* DateTime date1 = new DateTime(2019,6,14);
             DateTime date2 = new DateTime(2018, 6, 20);
             dateDiff(date1, date2);*/

            //t2
            /*string[] numInStr = { "1a", "a", "2b", "b" };
            string[] result = NumInStr(numInStr);
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }*/

            //t3->already solved before

            //t4
           /* long x = 112233445566778899;
            Console.WriteLine(pandigitalNum(x));*/




        }
    }
}
