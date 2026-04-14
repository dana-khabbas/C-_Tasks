using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {//task1 :- Stores your name Stores your age Prints a message:
            /* Console.Write("Enter your name: ");
             string name = Console.ReadLine();

             Console.Write("enter you age: ");
             string age= Console.ReadLine();

             Console.WriteLine(" My name is "+name+" ,and I am "+age+" years old");
             Console.ReadLine();*/


            //t2
            /*int num=Console.Read();
            if(num%2==0) {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            Console.ReadLine();*/

            //t3
            /*Console.WriteLine("enter any string");
            string s=Console.ReadLine();
            Console.WriteLine(s);*/

            //t4
            /*Console.WriteLine("entaer any number");
            int x= Convert.ToInt32(Console.ReadLine());
            if(x == 0) { Console.WriteLine("the number is zero"); }
            else if (x > 0) { Console.WriteLine("it's a positive number"); }
            else if(x<0) { Console.WriteLine("its a negative number"); }
            */
            //t5 
            /*Console.WriteLine("enter any year");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x%4==0)
            {
                Console.WriteLine("this is a leap year");
            }
            else { Console.WriteLine("it's not a leap year"); }*/

            //t6 
            /*Console.WriteLine("enter your grade");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x>50)
            {
                Console.WriteLine("pass");
            }
            else { Console.WriteLine("fail"); }*/

            //t7
            /*Console.WriteLine("enter  number 1");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter  number 2");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > y) { Console.WriteLine("number1 is bigger "); }
            else { Console.WriteLine("number is equal or bigger than x"); }*/

            //t8
            /*Console.WriteLine("enter  number ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x%5==0 && x%3==0) { Console.WriteLine("the number is divisible by 5 and 3 "); }
            else { Console.WriteLine("the number is not divisible by 5 and 3 "); }*/

            //t9
            /* Console.WriteLine("enter one character to check if its vowel");
             char chr = Console.ReadLine()[0];

             if (chr =='a'|| chr == 'e'||chr == 'i'||chr == 'o'||chr == 'u') {  Console.WriteLine("its a vowel");}
             else { Console.WriteLine("not vowel"); }
            */
            //t10
            /* Console.WriteLine("enter  you age ");
             int x = Convert.ToInt32(Console.ReadLine());
             if(x <= 8) { Console.WriteLine("you are a child!"); }
             else if(x>8 && x <= 17) { Console.WriteLine("you are a teenager!"); }
             else if (x > 17) { Console.WriteLine("you are an adult !"); }*/

            //t11
            /*  Console.WriteLine("enter day number between 1-7 ");
              int x = Convert.ToInt32(Console.ReadLine());
              switch (x)
              {
              case 1: Console.WriteLine("it's sunday");break;
              case 2: Console.WriteLine("its monday");break;
              case 3: Console.WriteLine("its tuesday");break;
                  case 4: Console.WriteLine("it's wednsday"); break;
                  case 5: Console.WriteLine("its thursday"); break;
                  case 6: Console.WriteLine("its friday"); break;
                      case 7: Console.WriteLine("its saturday");break;
              }*/

            //t12
            /* Console.WriteLine("enter month number between 1-12 ");
             int x = Convert.ToInt32(Console.ReadLine());
             switch (x)
             {
                 case 1: Console.WriteLine("it's January"); break;
                 case 2: Console.WriteLine("its February"); break;
                 case 3: Console.WriteLine("its march"); break;
                 case 4: Console.WriteLine("it's april"); break;
                 case 5: Console.WriteLine("its may"); break;
                 case 6: Console.WriteLine("its june"); break;
                 case 7: Console.WriteLine("its july"); break;
                 case 8: Console.WriteLine("its August"); break;
                 case 9: Console.WriteLine("it's september"); break;
                 case 10: Console.WriteLine("its october"); break;
                 case 11: Console.WriteLine("its november"); break;
                 case 12: Console.WriteLine("its december"); break;
             }*/

            //t13
            /* Console.WriteLine("enter  number 1");
             int x = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter  number 2");
             int y = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter  the operator");
             string opr= Console.ReadLine();

             switch (opr)
             {
                 case "+":Console.WriteLine(x+y); break;
                 case "-": Console.WriteLine(x - y); break;
                 case "*": Console.WriteLine(x * y); break;
                 case "/": Console.WriteLine(x / y); break;
             }*/

            //t14
            /* 
             Console.WriteLine("enter  your grade ");
             string x = Console.ReadLine();

             switch (x.ToUpper())
             {
                 case "A": Console.WriteLine("Excellent"); break;
                 case "B": Console.WriteLine("Very Good"); break;
                 case "C": Console.WriteLine("Good"); break;
                 case "D": Console.WriteLine("Pass"); break;
                 case "E": Console.WriteLine("Fail"); break;
             }*/


            //t15
            /* Console.WriteLine("enter  Category number between 1-3  ");
             int x = Convert.ToInt32(Console.ReadLine());

             switch (x)
             {
                 case 1: Console.WriteLine("clothes"); break;
                 case 2: Console.WriteLine("technology"); break;
                 case 3: Console.WriteLine("food"); break;

             }*/

            //t16
            /* Console.WriteLine("enter  number");
            int x = Convert.ToInt32(Console.ReadLine());
            bool n=x%2==0?true:false;
                    switch (n)
                        {
                            case true:Console.WriteLine("its an even number");break;
                            case false:Console.WriteLine("its an odd number ");break;
                        }*/

            //t17
            /*  Console.WriteLine("enter  your role");
              string x = Console.ReadLine();
              switch (x.ToLower())
              {
                  case "admin": Console.WriteLine("you are the admin"); break;
                  case "user": Console.WriteLine("you are the user "); break;
                  case "guest": Console.WriteLine("you are a guest "); break;

              }*/

            //t18
            /*  Console.WriteLine("what do you like to drink? tea  or coffee ");
              string x = Console.ReadLine();
              switch (x.ToLower())
              {
                  case "tea": Console.WriteLine("your tea will be here in a minute");break;
                  case "coffee": Console.WriteLine("your coffe will be here in a minute"); break;
              }*/


            //*********************** If Statements – Advanced  Questions******************************
            //t1

            /* Console.WriteLine("enter  your performance rating ");
             int x = Convert.ToInt32(Console.ReadLine());

             if(x>=90 && x <= 100) { Console.WriteLine(" you are an Excellent employee, you'll take a 20% bonus"); }
             else if (x >= 75 && x <= 89) { Console.WriteLine(" you are a Very Good employee, you'll take a 15% bonus"); }
            else  if (x >= 60 && x <= 74) { Console.WriteLine(" you are a Good employee, you'll take a 10% bonus"); }
             else if (x < 60) { Console.WriteLine("sorry you are not gonna get any bonus"); }*/

            //t2
            /*  Console.WriteLine("please enter your grade ");
              int x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("did you pass the English test? [yes/no]");
              String y =Console.ReadLine();
              bool didPass= y=="yes"?true:false;
              Console.WriteLine("do you have a special recommendation? [yes/no]");
              String z = Console.ReadLine();
              bool hasRecommendation = z == "yes" ? true : false;

              if (x>=85 && didPass || hasRecommendation)
              {
                  Console.WriteLine("welcome to the university !");
              }*/

            //t3
            /*    Console.WriteLine("please enter the  weight ");
                int x = Convert.ToInt32(Console.ReadLine());

                if(x<=1) { Console.WriteLine("The delivery cost is 5$  "); }
                else if (x> 1 && x<=5) { Console.WriteLine("The delivery cost is 10$  "); }
                else if (x > 5 && x <= 10) { Console.WriteLine("The delivery cost is 20$  "); }
                else if (x > 10) { Console.WriteLine("The delivery cost is 50$ but the package is heavy  "); }*/

            //t4
            /*string correctUsername = "admin";
            string correctPassword = "1234";

            int attempts = 0;

            while (attempts < 3)
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (username == correctUsername && password == correctPassword)
                {
                    Console.WriteLine("Login successful");
                    return;
                }
                else
                {
                    attempts++;
                    Console.WriteLine("Invalid credentials");
                }
            }

            Console.WriteLine("Account locked");*/

            //******************** switch statments***************************
            
            //t1
            Console.Write("Enter menu choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.WriteLine("Burger - $5"); break;
                case 2: Console.WriteLine("Pizza - $8");break;
                case 3:Console.WriteLine("Pasta - $7");break;
                case 4: Console.WriteLine("Salad - $4");break;
                
            }

            //t2
            /*  Console.Write("Enter grade (A-F): ");
              char grade = Console.ReadLine()[0];



              switch (grade)
              {
                  case 'A': Console.WriteLine("Excellent");break;
                  case 'B':Console.WriteLine("Very Good");break;
                  case 'C':Console.WriteLine("Good"); break;
                  case 'D':Console.WriteLine("Pass"); break;
                  case 'F':Console.WriteLine("Fail");break;

              }*/

            //t3
            /*  Console.Write("Choose option(1-4): ");
              int x = Convert.ToInt32(Console.ReadLine());
              int  balance = 1000;

              switch (x)
              {
                  case 1:Console.WriteLine("Your balance: " + balance);break;

                  case 2:Console.Write("Enter amount to deposit: ");
                      int deposit = Convert.ToInt32(Console.ReadLine());
                      balance += deposit;
                      Console.WriteLine("New balance: " + balance);
                      break;

                  case 3:
                      Console.Write("Enter amount to withdraw: ");
                      int withdraw = Convert.ToInt32(Console.ReadLine());

                      if (withdraw <= balance)
                      {
                          balance -= withdraw;
                          Console.WriteLine("New balance: " + balance);
                      }
                      else
                      {
                          Console.WriteLine("Insufficient balance");
                      }
                      break;

                  case 4:
                      Console.WriteLine("Exiting");
                      break;

              }*/

            //t4
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Choose operation(1-4): ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;

                case 2:
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;

                case 3:
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;

                case 4:
                  
                        Console.WriteLine("Result: " + (num1 / num2));
                    break;

            }












        }
    }
}
