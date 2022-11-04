using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var car1 = new Car();
            car1.Make = "Nissan";
            car1.Model = "Sentra";
            car1.Cylinders = 4;
            car1.Trunk = true;
            car1.SunglassHolder = true;
            car1.SeatCount = 5;
            car1.CompanyLogo = "Infinity circle";
            car1.CompanyName = "Elevate Nissan";
            

            var truck1 = new Truck();
            truck1.Make = "Ford";
            truck1.Model = "F150";
            truck1.Cylinders = 8;
            truck1.BedSize = "Large";
            truck1.SeatCount = 2;
            truck1.LiftGate = false;
            truck1.CompanyLogo = "oval with Ford inside";
            truck1.CompanyName = "Olathe Ford";

            var suv1 = new SUV();
            suv1.Make = "GMC";
            suv1.Model = "Yukon";
            suv1.Cylinders = 8;
            suv1.SlidingDoors = false;
            suv1.CargoSize = "Large";
            suv1.SeatCount = 7;
            suv1.CompanyLogo = "red letters GMC";
            suv1.CompanyName = "Olathe GMC";


            var vehicleList = new List<IVehicle>();

            vehicleList.Add(car1);
            vehicleList.Add(truck1);
            vehicleList.Add(suv1);
            



                foreach (var vehicle in vehicleList)
                {
                    //DislayVehicleInfo
                    Console.WriteLine($"Company:    {vehicle.CompanyName,20}       Logo:   {vehicle.CompanyLogo,20}");
                    Console.WriteLine($"Make:       {vehicle.Make,20}       Model:  {vehicle.Model,20}");
                    Console.WriteLine($"Cylinders:  {vehicle.Cylinders,20}       Seats:  {vehicle.SeatCount,20}");
                   
                    //Access and display info from any missing fields above.
                    if (vehicle is Car)
                    {
                        Console.WriteLine($"Has Sunglasses Holder: {car1.SunglassHolder}");
                        Console.WriteLine();
                    }

                    if (vehicle is Truck)
                    {
                        Console.WriteLine($"Truck Bed Size:     {truck1.BedSize}");
                        Console.WriteLine($"Truck Has LiftGate: {truck1.LiftGate}");
                        Console.WriteLine();
                    }

                    if (vehicle is SUV)
                    {
                        Console.WriteLine($"SUV Sliding Side Doors: {suv1.SlidingDoors}");
                        Console.WriteLine($"SUV Cargo Size Size:    {suv1.CargoSize}");
                        Console.WriteLine();
                    }


                }

            }














        }
    }
}
