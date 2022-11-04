using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public string CargoSize { get; set; }
        public bool SlidingDoors { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogo { get; set; }
        public double Cylinders { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }

       
    }
}
