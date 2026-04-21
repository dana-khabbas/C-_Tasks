using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_c_
{
    public abstract class Employee
    {
        public string name { get; set; }

        public abstract double CalculateSalary();
    }
    public class FullTimeEmployee : Employee
    {
        public double monthSalary { get; set; }

        public override double CalculateSalary()
        {
            return monthSalary;
        }
    }

    public class PartTimeEmployee : Employee
    {
        public int hours { get; set; }
        public double price { get; set; }

        public override double CalculateSalary()
        {
            return price * hours; 
        }
    }

    class BankAccount
    {
        private double balance=0;
        public void Deposit (double x)
        {
            balance += x;
        }
        public void Withdraw(double x)
        {
            if(x < balance)
            {
                balance -= x;
            }
            else
            {
                Console.WriteLine("There is no  enough balance");
            }
        }
        public void GetBalance()
        {   
            Console.WriteLine("current blalnce is: "+ balance);
        }
    }
    abstract class Appliance
    {
        
        public abstract void TurnOn();
        public abstract void TurnOff();

        public string brand {  get; set; }
    }

    class WashingMachine : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine($"[{brand} Washing Machine] Starting wash cycle...");
        }
        public override void TurnOff()
        {
            Console.WriteLine($"[{brand} Washing Machine] Stopping wash cycle. Powering off.");
        }
    }

     class AirConditioner : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine($"[{brand} Air Conditioner] Cooling mode activated ❄️");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"[{brand} Air Conditioner] Shutting down cooling system.");
        }
    }
    abstract class Animals
    {
        public abstract void MakeSound();
    }

    class Cats : Animals
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow Meow");
        }
    }
    class Dogs : Animals
    {
        public override void MakeSound()
        {
            Console.WriteLine("Hoo Hoo");
        }
    }
    class Calculator
    {
        public static int  Add(int x, int y)
        {
            return x + y;
        }
        public static int Add(int x, int y,int z)
        {
            return x + y+z;
        }
        public static double Add(double  x, int y)
        {
            return x + y;
        }
    }
    class Person
    {
        private int age;
        public int Age// Public property to access the private field
        {
            get { return age; }
            set
            {
                if (value > 0) 
                    age = value;
            }
        }
    }
    abstract class Shape
    {
        public abstract double GetArea(double x, double y);
    }
    class Rectangle : Shape
    {
        public override double GetArea(double x,double y) 
        {
            return x * y;
        }
    }
    class Animal
    {
        public virtual void Speak() { Console.WriteLine("roar"); }

    }
    class Cat:Animal
    {
        public override void Speak() { Console.WriteLine("meow"); }

    }
    class over
    {
        public static int Add (int x, int y)
        {
            return x + y;
        }
        public static int Add (int x, int y,int z)
        {
            return x + y+z;
        }
}
    class Company
    {
        public static string CompName { get; set; }
        public string EmpName { get; set; }
    }
    class VisitCounter
    {
        public static int visitorsNum=0;
        public VisitCounter() { 
        visitorsNum++;}
    }
    class Converter
    {
        public static double CToF(double x)
        {
            return (x *1.8)+32 ;
        }
        public static double KToM(double x)
        {
            return (x * 0.621 ) ;
        }
    }
    static class MathUtilities
    {
       public  static double Square(double x) 
        {
        return Math.Pow(x,2);
        }

        public static double Root(double x)
        {
            return Math.Sqrt(x);
        }

        public static double Max(double x, double y)
        {
            return x>y?x:y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //t1
            //MathUtilities on = new MathUtilities(); --> error because we cant make object from static class
            /*Console.WriteLine(MathUtilities.Square(5));
            Console.WriteLine(MathUtilities.Root(16));
            Console.WriteLine(MathUtilities.Max(15,20));*/

            //t2
            /* Console.WriteLine(Converter.CToF(28));
             Console.WriteLine(Converter.KToM(30));*/

            //t3
            /* VisitCounter v=new VisitCounter();
             VisitCounter v2=new VisitCounter();
             VisitCounter v3=new VisitCounter();
             Console.WriteLine(VisitCounter.visitorsNum);*/

            //t4
            /*Company.CompName = "Progress Soft";
            Company c1 = new Company();
            c1.EmpName = "Sara";
            Company c2 = new Company();
            c2.EmpName = "Rola";
            Console.WriteLine("Company name is: "+Company.CompName+", Emplyee name is: "+c1.EmpName);
            Console.WriteLine("Company name is: "+Company.CompName+", Emplyee name is: "+c2.EmpName);
            */
            //t5
            //t5-1:overLoading
            /*   Console.WriteLine(over.Add(5 , 1));
               Console.WriteLine(over.Add(5 , 1,7));
            //t5-(2-5) are methods up
             */

            //t6
            /* Console.WriteLine(Calculator.Add(5, 1));
             Console.WriteLine(Calculator.Add(5, 1, 7));
             Console.WriteLine(Calculator.Add(5.6, 1));*/

            //t7
            /* Cats c1 = new Cats();
             c1.MakeSound();

             Dogs dogs = new Dogs();
             dogs.MakeSound();*/

            //t8
            /*WashingMachine wm = new WashingMachine();
            wm.brand = "Samsung";
            wm.TurnOn();
            wm.TurnOff();

            Console.WriteLine();

            AirConditioner ac = new AirConditioner();
            ac.brand = "LG";
            ac.TurnOn();
            ac.TurnOff();*/

            //t9
            /* BankAccount account = new BankAccount();
             account.Deposit(50);
             account.GetBalance();
             account.Withdraw(20);
             account.GetBalance();
             account.Withdraw(40);
             account.GetBalance();*/

            //t10
            FullTimeEmployee f = new FullTimeEmployee();
            f.name = "Ahmad";
                f.monthSalary = 1200;
            

            Console.WriteLine($"{f.name} Salary: {f.CalculateSalary()}");

            // Part-time employee
            PartTimeEmployee p = new PartTimeEmployee();
            p.name = "Sara";
                p.hours = 80;
            p.price = 5;
            

            Console.WriteLine($"{p.name} Salary: {p.CalculateSalary()}");


        }
    }
}
