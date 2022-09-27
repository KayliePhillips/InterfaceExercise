using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise 
{
        // DONE In each of your car, truck, and suv classes
        // DONECreate 2 members that are specific to each class
    public class SUV : IVehicle, ICompany
    {
        public double CargoSize { get; set; }

        public bool Is4WheelDrive { get; set; }

        public string Make { get; set; }
        public int NumberOfTires { get; set; }
        public int NumberOfDoors { get; set; }
        public bool HasSunRoof { get; set; }
        public string Logo { get; set; }
        public string HeadQuartersLocation { get; set; }

        public void PrintSUVInfo()
        {
            Console.WriteLine($"Make:{Make}");
            Console.WriteLine($"Headquaters Location: {HeadQuartersLocation}");
            Console.WriteLine($"Logo Description: {Logo}");
            Console.WriteLine($"Number of Tires: {NumberOfTires}");
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
            Console.WriteLine($"Does it have a sunroof? {HasSunRoof}");
            Console.WriteLine($"The cargo size is {CargoSize} cubic feet");
            Console.WriteLine($"Does it have four wheel drive? {Is4WheelDrive}");
        }





    }
}
