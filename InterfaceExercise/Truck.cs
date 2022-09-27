using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    // DONE In each of your car, truck, and suv classes
    //DONE  Create 2 members that are specific to each class
    internal class Truck : IVehicle, ICompany
    {
        public double BedLength { get; set; }

        public double ClearanceHeight { get; set; }
        public string Make { get; set; }
        public int NumberOfTires { get; set; }
        public int NumberOfDoors { get; set; }
        public bool HasSunRoof { get; set; }
        public string Logo { get; set; }
        public string HeadQuartersLocation { get; set; }

        public void PrintTruckInfo()
        {
            Console.WriteLine($"Make:{Make}");
            Console.WriteLine($"Headquaters Location: {HeadQuartersLocation}");
            Console.WriteLine($"Logo Description: {Logo}");
            Console.WriteLine($"Number of Tires: {NumberOfTires}");
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
            Console.WriteLine($"Does it have a sunroof? {HasSunRoof}");
            Console.WriteLine($"Bed Length is {BedLength} feet");
            Console.WriteLine($"The clearance height is {ClearanceHeight} feet");
        }
    
    
    
    }

}
