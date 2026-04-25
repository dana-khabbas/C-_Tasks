using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace C__Tasks____Methods_List_LINQ_LinkedList_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //t1
            /* List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
             List<int> ints2 = new List<int>();
             var result = ints.Where(n => n%2==0);

             foreach (var num in result)
             {
                 ints2.Add(num);   
             }

             foreach (int num in ints2)
             {
                 Console.WriteLine(num);
             }*/

            //t2
            /* List<int> ints = new List<int> { 1, 2,1,1,2,3, 3, 4, 5,4, 6, 7, 6,8, 9, 10 };
             var num =ints.Distinct();
             foreach (int i in num)
             {
                 Console.WriteLine(i);
             }*/

            //t3
            /*List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 17, 8, 9, 10 };
            var num=ints.Max(i => i);
            Console.WriteLine(num);*/

            //t4
            /*List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ints.Reverse();
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }*/

            //t5
            /*List<int> ints = new List<int> { 1, 70, 3, 4, 55, 60, 7, 8, 9, 10 };
            var num = ints.Count(i=>i>50);
            Console.WriteLine(num);*/

            // *************AccessControlSections 2 Dictionary************
            //t6
            /*Dictionary<String,int> keyValuePairs = new Dictionary<String,int>();
             keyValuePairs["Sara"] = 70;
             keyValuePairs["Tala"] = 95;
             keyValuePairs["Roaa"] = 82;
             foreach(var pair in keyValuePairs)
             {
                 if (pair.Value > 80)
                 {
                     Console.WriteLine(pair.Key);
                 }
             }*/

            //t7
            /*Dictionary<String, int> keyValuePairs = new Dictionary<String, int>();
            keyValuePairs["Sara"] = 70;
            keyValuePairs["Tala"] = 95;
            keyValuePairs["Roaa"] = 82;
            string s=Console.ReadLine();
            if (keyValuePairs.ContainsKey(s))
            {
                Console.WriteLine(keyValuePairs[s]);
            }*/

            //t8
            /*Dictionary<String, int> keyValuePairs = new Dictionary<String, int>();
            keyValuePairs["Sara"] = 70;
            keyValuePairs["Tala"] = 95;
            keyValuePairs["Roaa"] = 82;
           
            Console.WriteLine(keyValuePairs.Values.Sum());*/

            //t9
            /*Dictionary<String, int> keyValuePairs = new Dictionary<String, int>();
            keyValuePairs["Sara"] = 40;
            keyValuePairs["Tala"] = 95;
            keyValuePairs["Roaa"] = 82;
            foreach(var  pair in keyValuePairs.ToList())
            {
                if (pair.Value < 50)
                {
                    keyValuePairs.Remove(pair.Key);
                }
            }

            foreach(var pair in keyValuePairs)
            {
                Console.WriteLine(pair.Key);
            }*/

            //t10
            /* Dictionary<String, int> keyValuePairs = new Dictionary<String, int>();
             keyValuePairs["Sara"] = 40;
             keyValuePairs["Tala"] = 95;
             keyValuePairs["Roaa"] = 82;

             var num =keyValuePairs.Values.Max();
             Console.WriteLine(num);*/

            //t11
            /*LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddFirst("c");
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }*/

            //t12
            /* LinkedList<string> list = new LinkedList<string>();
             list.AddLast("a");
             list.AddLast("b");
             list.AddFirst("c");
             int index = (int)Math.Ceiling(list.Count / 2.0) ;

             var current = list.First;

             for (int i = 0; i < index; i++)
             {
                 current = current.Next;
             }

             list.Remove(current);

             foreach (var item in list)
             {
                 Console.WriteLine(item);
             }*/

            //t13

            /*LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddFirst("c");

            list.AddBefore(list.Last, "D");
            foreach(string item in list) { 
                Console.WriteLine(item);
            }*/
            //t14
            /* LinkedList<string> list = new LinkedList<string>();
             list.AddLast("a");
             list.AddLast("b");
             list.AddFirst("c");
             foreach (string item in list)
             {
                 Console.WriteLine(item);
             }*/

            //t15

            /*  LinkedList<string> list = new LinkedList<string>();
              list.AddLast("a");
              list.AddLast("b");
              list.AddFirst("c");

              Console.WriteLine(list.First.Value);
              Console.WriteLine(list.Last.Value);*/

            //*****************LINQ *********************
            //t16
            /* List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9};
             var nums=list.Where(x => x %2!=0).ToList();
             foreach(var num in nums)
             {
                 Console.WriteLine(num);
             }*/

            //t17
            /*List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var nums = list.Select(x => x * 2).ToList();
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }*/

            //t18
            /*List<int> list = new List<int>() { 3,1, 2, 6, 4, 5, 6, 7, 8, 9 };
            var nums =list.OrderByDescending(x => x).ToList();
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }*/

            //t19
            /* List<int> list = new List<int>() { 15, 22, 34, 41, 5, 6, 107, 800, 9 };

             var firstNumber = list.FirstOrDefault(n => n > 100);
             Console.WriteLine(firstNumber);*/

            //t20
            /* List<int> list = new List<int>() { 15, 22, 34, 41, 5, 6, 107, 800, 9 };
             var num=list.Average();
             Console.WriteLine(num);*/

            //t21
            /* List<int> list = new List<int>() { 15, 22, 34, 41, 5, 6, 107, 800, 9 };
             List<int> list2 = new List<int>() { 1, 20, 34, 41, 5, 61, 10, 80, 9 };
             List<int> common = new List<int>();

             foreach (int num in list)
             {
                 if (list2.Contains(num))
                 {
                     common.Add(num);
                 }
             }

             foreach (int num in common)
             {
                 Console.WriteLine(num);
             }*/

            //t22
            /*List<int> list = new List<int>() { 15, 22, 34, 41, 5, 6, 107, 800, 9 };
            List<int> list2 = new List<int>() { 1, 20, 34, 41, 5, 61, 10, 80, 9 };
            var con = list.Concat(list2).ToList();
            foreach (var item in con)
            {
                Console.WriteLine(item);
            }*/

            //t23
            /*List<int> list = new List<int>() { 15, 22,22,15,5,6, 34, 41, 5, 6, 107, 800, 9 };
            var n=list.Distinct().ToList();
            foreach (int i in n)
            {
                Console.WriteLine(i);
            }*/

            //t24
            /*Dictionary<String, int> keyValuePairs = new Dictionary<String, int>();
            keyValuePairs["Sara"] = 40;
            keyValuePairs["Tala"] = 95;
            keyValuePairs["Roaa"] = 82;
            
            List<int> lits = new List<int>();
            foreach(var pair in keyValuePairs) {
                lits.Add(pair.Value);
            }
            foreach(var i in lits)
            {
                Console.WriteLine(i);
            }*/

            //t25
            /*Dictionary<String, int> keyValuePairs = new Dictionary<String, int>();
            keyValuePairs["Sara"] = 400;
            keyValuePairs["Tala"] = 95;
            keyValuePairs["Roaa"] = 820;

            List<string> remove = new List<string>();

            foreach (var pair in keyValuePairs)
            {
                if (pair.Value < 100)
                {
                    remove.Add(pair.Key);
                }
            }

            foreach(var key in remove)
            {
                keyValuePairs.Remove(key);
            }
            foreach (var pair in keyValuePairs)
            {
                Console.WriteLine(pair.Key);
                
            }*/

            //t26
            /* List<int> list = new List<int>() { 38, 28, 99, 100, 6 };
             bool numExciste = false;
             foreach (int i in list)
             {
                 if (list.Contains(100))
                 {
                     numExciste = true;
                 }
             }

             Console.WriteLine(numExciste);*/

            //t27
            /* List<int> list = new List<int>() { 38, 28, 99, 100, 6 };
             int count = 0;
             foreach (int i in list)
             {
                 if (i%2==0)
                 {
                     count++;
                 }
             }

             Console.WriteLine(count);*/

            //t28
            /*List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] % 2 == 0)
                {
                    list.RemoveAt(i);
                }
            }

            foreach (var num in list)
            {
                Console.WriteLine(num);
            }*/

            //t29
            /*List<int> list = new List<int>() { 38, 28, 99, 100, 6 };
            int max1=list.ElementAt(0);
            int max2=list.ElementAt(0);
            foreach(int i in list)
            {
                if(i > max1)
                {
                    max2 = max1;
                    max1 = i;
                }

                if(i>max2 && i < max1)
                {
                    max2 = i;
                }
            }

            Console.WriteLine(max2);*/

            //  ***********************************Advanced Logic Tasks(List &Array)*******************

            //t1
            /*int[] x = { 1, 3, 2, 1, 1, 3, 3, 2, 77, 7, 7, 1, 1, 1 };
            Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();

            for (int i = 0; i < x.Length; i++)
            {
                if (keyValuePairs.ContainsKey(x[i]))
                {
                    keyValuePairs[x[i]]++;
                }
                else
                {
                    keyValuePairs.Add(x[i], 1);
                }
            }
            int maxKey=keyValuePairs.ElementAt(0).Key;
            int maxValue=keyValuePairs.ElementAt(0).Value;


            foreach(var pair in  keyValuePairs)
            {
               if (pair.Value > maxValue)
                {
                    maxKey = pair.Key;
                    maxValue = pair.Value;
                }
            }
            Console.WriteLine(maxKey);*/

            //t2
            int[] x = { 1, 2, 3, 4, 5,6 };
            int n = 2;
            int save;
            int change;
            for (int i = 0; i < x.Length; i++)
            {
                save = x[i];
                x[(i+n)%x.Length] = save;

                
            }

            foreach (int i in  x)
            {
                Console.WriteLine(i);
            }



        }
    }
}
