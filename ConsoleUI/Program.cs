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
            var inventory = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            var myPilot = new Car() { HasTrunk= true, Year="2015", Make="Honda", Model="Pilot" };
            var myGoldWing = new Motorcycle() { HasSidecar= false, Model="Gold Wing" };
            Vehicle myGeneric1 = new Car() { HasTrunk= true };
            Vehicle myGeneric2 = new Motorcycle() { HasSidecar= true };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            inventory.Add(myPilot);
            inventory.Add(myGoldWing);
            inventory.Add(myGeneric1);
            inventory.Add(myGeneric2);

            foreach (Vehicle v in inventory)
            {
                Console.WriteLine(v.Make + ", " + v.Model + " " + v.GetType().Name);
                // Call each of the drive methods for one car and one motorcycle
                v.DriveAbstract();
                v.DriveVirtual();
                Console.WriteLine();
            }

            #endregion       
        }
    }

    public abstract class Vehicle
    {
        public string Year { get; set; } = "Def Yr";
        public string Make { get; set; } = "Def Mk";
        public string Model { get; set; } = "Def Md";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Look at me vdriving (Vehicle class).");
        }
    }

    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Look at me adriving (Car class).");
        }
    }

    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Look at me adriving (Motorcycle class).");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Look at me vdriving (Motorcycle class).");
        }
    }

}
