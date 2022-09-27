using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE Create 2 Interfaces called IVehicle & ICompany

            //DONE Create 3 classes called Car , Truck , & SUV

            //DONE In your IVehicle

            /* DONE Create 4 members that Car, Truck, & SUV all have in common.
                    * Example: All vehicles have a number of wheels... for now..
            */


            //DONE In ICompany

            /*DONE Create 2 members that are specific to each every company
                    * regardless of vehicle type.
                    *
                    *
                    * Example: public string Logo { get; set; }
             */

            //DONE In each of your car, truck, and suv classes

            /*DONE Create 2 members that are specific to each class
             * DONE Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * DONE Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //DONE Now, create objects of your 3 classes and give their members values;
            //DONE Creatively display and organize their values

            var truck1 = new Truck()
            {
                Make = "Ford",
                HeadQuartersLocation = "Dearborn, MI",
                Logo = "Blue oval with Ford written inside in white",
                NumberOfDoors = 4,
                NumberOfTires = 4,
                HasSunRoof = false,
                BedLength = 6,
                ClearanceHeight = 6.5,
            };

            var suv1 = new SUV()
            {
                Make = "Honda",
                HeadQuartersLocation = "Tokya, Japan",
                Logo = "Square with the letter H inside",
                NumberOfDoors = 4,
                NumberOfTires = 4,
                HasSunRoof = true,
                CargoSize = 39.2,
                Is4WheelDrive = true,
            };

            var car1 = new Car()
            {
                Make = "Tesla",
                HeadQuartersLocation = "Austin, TX",
                Logo = "The Tesla logo is meant to resemble a cross-section of an electric motor.",
                NumberOfDoors = 2,
                NumberOfTires = 4,
                HasSunRoof = false,
                HasTrunk = true,
                TrunkSize = 19.8,
            };

            truck1.PrintTruckInfo();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            suv1.PrintSUVInfo();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            car1.PrintCarInfo();


        }
    }
}

