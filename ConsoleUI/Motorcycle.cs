using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("This car is an override abstract drive");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("This is an override virtual drive");
        }


    }

}