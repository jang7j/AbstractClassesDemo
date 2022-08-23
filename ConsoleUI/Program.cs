using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */



            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var list = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class (make an instance) 
             * Set the properties with object initializer syntax
             */
            Car car = new Car() { HasTrunk = true, Make = "Ford", Model = "Focus", Year = "2009" };
            Motorcycle motorcycle = new Motorcycle() { HasSideCart = false, Make = "HD", Model = "Model", Year = "2020" };
            Vehicle vehicle1 = new Car() { HasTrunk = true, Make = "Dodge", Model = "Dodgeball", Year = "2011" };
            Vehicle motorcycle2 = new Motorcycle() { HasSideCart = true, Make = "HD", Model = "HDModel", Year = "2000" };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            list.Add(car);
            list.Add(motorcycle);
            list.Add(vehicle1);
            list.Add(motorcycle2);

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Make} {item.Model} {item.Year}");
                item.DriveAbstract();

            }
            // Call each of the drive methods for one car and one motorcycle

            car.DriveAbstract();
            motorcycle.DriveVirtual();
            vehicle1.DriveAbstract();
            motorcycle2.DriveVirtual();


            #endregion
            Console.ReadLine();
        }
    }
}
