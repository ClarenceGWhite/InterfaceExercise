using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car() 
        {
        }


        public bool Trunk { get; set; } = true;
        public bool SunglassHolder { get; set; } = true;
        public string CompanyName { get; set; } = "Generic Company";
        public string CompanyLogo { get; set; } = "Round Circle";
        public double Cylinders { get; set; } = 6;
        public string Make { get; set; } = "Generic Make";
        public string Model { get; set; } = "Generic Model";
        public int SeatCount { get; set; } = 5;


       
       


    }
}
