using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    //DONE In each of your car, truck, and suv classes
    //DONE Create 2 members that are specific to each class
    internal class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }
        public double TrunkSize { get; set; }
        public string Make { get; set; }
        public int NumberOfTires { get; set; }
        public int NumberOfDoors { get; set; }
        public bool HasSunRoof { get; set; }

        public string Logo { get; set; }
        public string HeadQuartersLocation { get; set; }

        public void PrintCarInfo()
        {
            Console.WriteLine($"Make:{Make}");
            Console.WriteLine($"Headquaters Location: {HeadQuartersLocation}");
            Console.WriteLine($"Logo Description: {Logo}");
            Console.WriteLine($"Number of Tires: {NumberOfTires}");
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
            Console.WriteLine($"Does it have a sunroof? {HasSunRoof}");
            Console.WriteLine($"Does it have a trunk? {HasTrunk}");
            Console.WriteLine($"The trunk is {TrunkSize} cubic feet");
        }




    }
}
