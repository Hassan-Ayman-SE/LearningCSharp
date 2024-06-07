using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_
{
    class Car
    {
        String make;
        String model;
        int year;
        String color;
        public static int numberOfCars;



        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
            numberOfCars++;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }

        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }
    }

}
