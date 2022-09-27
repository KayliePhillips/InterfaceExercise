using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{

    //In your IVehicle

    /* DONE  Create 4 members that Car, Truck, & SUV all have in common.
     * Example: All vehicles have a number of wheels... for now..
     */
    public interface IVehicle
    {

        public string Make { get; set; }
        public int NumberOfTires { get; set; }
        public int NumberOfDoors { get; set; }
        public bool HasSunRoof { get; set; }
        




    }
}
