using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_in_C_
{
    /// <summary>
    /// test to push to git hub
    /// </summary>
    class Person
    {
        //t1
        public string Name { get; set; }// this is Auto (property)
        private int age;//--> this is filed
        public void SetAge(int a)
        {
            age = a;
            
        }

       
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {age}");
        }
    }

    class Student:Person {
        public string Major { get; set; }//this is auto properity

        
        public void PrintStudentInfo()
        {
            PrintInfo();
            Console.WriteLine($"Major: {Major}");
        }
    }

    //bonus
   /*     sealed class vehicle
    {
        int x = 0;
    }

    public class Car : vehicle*/ //--> this is error

        //t2
        public class Car
        {
            private bool isEngineOn=false;
            public void setIsEngineOn(bool isEngineOn)
            {
                this.isEngineOn = isEngineOn;
            }
            public bool getIsEngineOn()
            {
                return isEngineOn;
            }
        private string make; //these all vaiables are field because they do not have get and set
        private int year;
        private string type;
        private double price;
        private string model;
        private string palletNo;
        private string color;

            public Car(string m,int y,string t,double p, string mo, string pN, string c)
            {
                this.make = m;
                this.year = y;
                this.type = t;
                this.price = p;
                this.model = mo;
                this.palletNo = pN;
                this.color = c;
            }
            public string CarInfo()
        {
            return "the car make is: " + this.make +"\n"+
                "the car year is: " + this.year + "\n" +
                "the car type is: " + this.type + "\n" +
                "the car price is: " + this.price + "\n" +
                "the car model is: " + this.model + "\n" +
                "the car palletNo is: " + this.palletNo + "\n" +
                "the car Color is: " + this.color;

        }
        }


    internal class Program
    {

        static void Main(string[] args)
        {
            //t1
             Student s1 = new Student();


             s1.Name = "Dana";

             s1.SetAge(22);
             s1.Major = "Computer Information Systems";


             s1.PrintStudentInfo();

            //t2

            Car c = new Car("Toyota", 2020, "Camery", 5000, "Fourwheel", "J-234", "grey");
            Console.WriteLine(c.CarInfo());
            c.setIsEngineOn(true);
            Console.WriteLine("is the car engine on?"+c.getIsEngineOn());
        }
    }
}
