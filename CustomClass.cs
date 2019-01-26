using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Creating_an_Custom_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a new object of class car
            Car MyCar = new Car();

            // setting the color, year, make, and model of the object
            // by the user input
            Console.WriteLine("What color would you like?");
            MyCar.Color = Console.ReadLine();
            Console.WriteLine("What year would you like?");
            MyCar.Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What maker would you like?");
            MyCar.Make = Console.ReadLine();
            Console.WriteLine("What model would you like?");
            MyCar.Model = Console.ReadLine();

            // how to get the properties out of the object
            Console.WriteLine(" Color:{0}\n Maker:{1}\n Model:{2}\n Year:{3}\n", MyCar.Color, MyCar.Make, MyCar.Model, MyCar.Year);

            // To retrieve the returned carValue from the helper double method
            // Can call the method based on the instance of the class object MYCAR
            double CarValue = DetermineMarketValue(MyCar);

            // to call method Determine Market Value
            // using :C to insert a dollar sign
            Console.WriteLine("The car value is: \n{0:C}",MyCar.Determine_Market_Value());
        }
        //Created a helper method of the class Car called car which contains the value of the car
        // Using Class Car like an Datatype to declare a variable named car 
        //Created a method that part of the class that can be called by the instance of the class Car
        private static double DetermineMarketValue(Car car)
        {
            double CarValue = 99.99;
            return CarValue;
        }
    }
    class Car
    {
        // setting the properties of class Car
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        // Creating a method construct
        public double Determine_Market_Value()
        {
            double CarValue = 99.99;
            // using This followed by a period
            // the inteller system knows that This is pinpointing to 
            // this specific class
            if(this.Year > 1990)
                CarValue = 10000;
            else
            CarValue = 20000;

            return CarValue;
        }
    }
}
