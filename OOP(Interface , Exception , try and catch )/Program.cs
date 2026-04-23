using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_Interface___Exception___try_and_catch__
{
    interface ICalculator
    {
        int Add(int a, int b);
    }
    class Calculator : ICalculator
    {
        public  int Add(int a, int b) { return a + b; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //t1:interface+try and catch
            /*Console.WriteLine("please enter 2 numbers");

            try {
            int x= Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
               Calculator c = new Calculator();
                Console.WriteLine(c.Add(x, y));
            } catch (Exception e) { Console.WriteLine("there was error in the input"); }*/

            //t2 file read and write
            try {
                
                File.AppendAllText("doc.txt", "\nI live in Amman");
                string[] lines = File.ReadAllLines("doc.txt");

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            } catch(Exception e) {
                Console.WriteLine("an error occured while reading or writing on the file" );
                Console.WriteLine(e.Message);
            }

        }
    }
}
