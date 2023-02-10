using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

// CODED BY KATHLEEN FORGIARINI DA SILVA
// 2023-02-09
// Lab 3.6 – Create the class Car with 6 fields and Proprieties

namespace lab3._6
{
    class Car
    {
        // private fields
        private string cartype;
        private string model;
        private string color;
        private int year;
        private double weight;
        private double length;

        // public properties
        public string Cartype
        {
            get
            {
                return cartype;
            }
            set
            {
                cartype = value;
            }
        }
        public string Model {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value < 2022 && value > 2019)
                {
                    year = 2019;
                }
                else
                {
                    year = value;
                }
            }
        }
        public double Weight {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public double Length {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        // default constructor
        public Car()
        {
            Cartype = "Ford";
            Model = "Focus";
            Color = "Blue";
            Year = 2020;
            Weight = 1500;
            Length = 2.45;
        }

        // overloaded constructor
        public Car(string cartype, string model, string color, int year, double weight, double length)
        {
            Cartype = cartype;
            Model = model;
            Color = color;
            Year = year;
            Weight = weight;
            Length = length;
        }

        // Display method to display the information about the car
        public void Display()
        {
            Console.WriteLine("Car Type: {0}\nModel: {1}\nColor: {2}\nYear: {3}\nWeight: {4}\nLength: {5}", cartype, model, color, year, weight, length);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car c1, c2, c3, c4; // object c1-c4

            c1 = new Car();// instantiate the object with default constructor
            Console.WriteLine("Display from Display() Method:");
            c1.Display();

            // ask for data for c2
            enterc2:
            try
            {
                Console.WriteLine("\nEnter data for Car 2:");
                Console.Write("Enter Car Type: ");
                string cartype1 = Console.ReadLine();
                Console.Write("Enter Model: ");
                string model1 = Console.ReadLine();
                Console.Write("Enter Color: ");
                string color1 = Console.ReadLine();
                Console.Write("Enter Year: ");
                int year1 = int.Parse(Console.ReadLine());
                Console.Write("Enter Weight: ");
                double weight1 = double.Parse(Console.ReadLine());
                Console.Write("Enter Length: ");
                double length1 = double.Parse(Console.ReadLine());
                c2 = new Car(cartype1, model1, color1, year1, weight1, length1);
                Console.WriteLine("\nDisplay car 2:");
                c2.Display();
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input. Exception: " + e.Message);
                goto enterc2;
            }

            c3 = new Car("Nissan", "Versa", "Green", 2021, 1800, 2.9);
            Console.WriteLine("\nDisplay car 3:");
            c3.Display();

            c4 = new Car("Ford", "Ka", "Red", 2017, 1500, 2.0);
            Console.WriteLine("\nDisplay car 4:");
            c4.Display();

            Console.ReadKey();
        }
    }
}
