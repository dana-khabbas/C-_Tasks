using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_3_
{
    internal class Program
    {
        static int add(int x, int y)
        {
            return x + y;
        }
        static string RemoveLeadingTrailing(string n)
        {
           
            n = n.TrimStart('0');

            if (n.Contains("."))
            {
                
                n = n.TrimEnd('0');

                if (n.EndsWith("."))
                    n = n.TrimEnd('.');
            }

            return n;
        }

        //t3
        static int secondLargest(int[] x)
        {
            int max = x[0];
            int max2 = x[0];
            foreach(int z in x)
            {
                if (z > max)
                {
                    max2 = max;
                    max = z;
                }
                else if (z > max2 && z != max)
                {
                    max2 = z;
                }
            }
            return max2;
        }

        static bool isRepdigit(int x)
        {
            if (x >= 0) {
                int y = x % 10;
                x = x / 10;
                while (x > 0)
                {
                    int z = x % 10;
                    x = x / 10;
                    if (z != y)
                    { return false; }
                }
                return true;
            }
            else return false;
        }

        //t5
        static string reverseWords(string s)
        {
            List<string> st=new List<string>();
            string[] st2 = s.Split(' ');
            foreach (string s2 in st2)
            {
                st.Insert(0, s2);
            }
            return string.Join(" ",st);
        }

        static string boom(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 7) { return "boom"; }
            }
            return "there is no 7 in the array";
        }

        static string space(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                result += str[i];

               
                if (i < str.Length - 1 &&
                    char.IsLower(str[i]) &&
                    char.IsUpper(str[i + 1]))
                {
                    result += " ";
                }
            }

            return result;
        }

        static int countTrue(bool[] x) {
            int count = 0;
            foreach (bool z in x)
            {
                if (z == true)
                {
                    count++;
                }
            }
            return count;
        }

        static string capToFront(string str)
        {
            string big = "";
            string small = "";

            foreach (char c in str)
            {
                if (char.IsUpper(c))
                    big += c;
                else
                    small += c;
            }

            return big + small;
        }

        static bool matchLastItem(string[] s)
        { string result = "";
            for(int i=0;i<=s.Length-2;i++) {
                result += s[i];
            }
            return result == s[s.Length - 1] ? true:false ;
        }

        static int findNaN(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (double.IsNaN(arr[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        static T[] removeDups<T>(T[] arr)
        {
            List<T> result = new List<T>();

            foreach (T item in arr)
            {
                if (!result.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }

        static string convertTime(DateTime dt)
        {
            return dt.ToString("HH:mm:ss");
        }

        static string removeLastVowel(string s)
        {
            string vowels = "aeiouAEIOU";
            string[] words = s.Split(' ');

            for (int x = 0; x < words.Length; x++)
            {
                for (int i = words[x].Length - 1; i >= 0; i--)
                {
                    if (vowels.Contains(words[x][i]))
                    {
                        words[x] = words[x].Remove(i, 1);
                        break;
                    }
                }
            }

            return string.Join(" ", words);
        }

        static double sumOfCubes(int[] x)
        {
            double result = 0;
            foreach(int i in x)
            {
                result += Math.Pow(i,3);
            }
            return result;
        }

        static void Main(string[] args)
        {
            //t1
            /* Console.WriteLine(add(1, 2));*/

            //t2
            /* Console.WriteLine(RemoveLeadingTrailing("03.1400"));*/

            //t3
            /*int[] x = { 10, 40, 30, 20, 50 };
            Console.WriteLine(secondLargest(x));*/

            //t4
            /* Console.WriteLine(isRepdigit(-11));*/

            //t5
            // Console.WriteLine(reverseWords("the sky is blue"));

            //t6
            /* int[] x = { 1, 5, 8, 9 };
             Console.WriteLine(boom(x));*/

            //t7
            /* Console.WriteLine(space("TheGreatestUpsetInHistory"));*/

            //t8
            /* bool[] x = { true, false, false, true, false };
             Console.WriteLine(countTrue(x));*/

            //t9
            //Console.WriteLine(capToFront("shOrtCAKE"));

            //t10
            /*string[] x = { "8", "thunder", "true", "8thundertrue" };
            Console.WriteLine(matchLastItem(x));*/

            //t11
            /*double[] x = { 1, 2, double.NaN };
            Console.WriteLine(findNaN(x));*/

            //t12
            /* string[] arr = { "John", "Taylor", "John" };
             int[] arr2 = { 1, 0, 1, 0 };

             Console.WriteLine(string.Join(", ", removeDups(arr)));
             Console.WriteLine(string.Join(", ", removeDups(arr2)));*/

            //t13
            //i used ai here to get functions
            /* DateTime t =  DateTime.Parse("07:05:45PM");
             DateTime t2 =  DateTime.Parse("12:40:22AM");
             DateTime t3 =  DateTime.Parse("12:45:54PM");

             Console.WriteLine(convertTime(t));
             Console.WriteLine(convertTime(t2));
             Console.WriteLine(convertTime(t3));*/

            //t14
            /*   string s = "Those who dare to fail miserably can achieve greatly";
               string s2 = "Love is a serious mental disease";
               Console.WriteLine(removeLastVowel(s));
               Console.WriteLine(removeLastVowel(s2));*/

            //t15
           /* int[] x = { 1, 5, 9 };
            Console.WriteLine(sumOfCubes(x));*/







        }
    }
}
