using System;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "2010";
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Mustang";

        public abstract void DriveAbstract(); //no implemtation (stubbed out method)
        public virtual void DriveVirtual()
        {
            Console.WriteLine("This is a virtual drive");
        }
    }
}