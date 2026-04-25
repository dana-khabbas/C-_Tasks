using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods___Collections_in_C_
{
    internal class Program
    {
        //T1
        static double CalculateAverage(int x,int y, int z)
        {
            double avg = (x + y + z) / 3;
            return avg;
        }
        static void Main(string[] args)
        {
            //T1
            /* Console.WriteLine( CalculateAverage(1, 2, 3));*/

            //T2
            /* List<string> studentNames = new List<string>();
             studentNames.Add("sara");
             studentNames.Add("ahmad");
             studentNames.Add("khaled");
             studentNames.Add("lara ");
             studentNames.Add("zina");
             foreach (string std in studentNames)
             {
                 Console.WriteLine(std);
                 if (std == "khaled") { Console.WriteLine("removed khaled"); }
             }*/

            //t3
            /*Dictionary<int, string> users = new Dictionary<int, string>();

            users.Add(1, "sanad");
            users.Add(2, "ali");
            foreach (var item in users)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }*/

            //t4
            int[] numbers = { 5, 10, 15, 20, 25, 30 };
            string[] names = { "Ahmad", "Ali", "Sara", "Mona", "Omar" };






        }
    }
}
