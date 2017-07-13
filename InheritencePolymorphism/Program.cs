using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritencePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat1 = new Boat(2, 500, "white and yellow", 70.0d, .78d);
            boat1.Move();
            boat1.Move();
            Console.WriteLine("Boat " + boat1.GetDistanceTraveled());

            Automobile car1 = new Automobile(4, 20, 4, 5, 5000, "red", 260);
            car1.Move();    //method inherited from Vehicle
            car1.Color = "gold";    //to change property
            Console.WriteLine("Automobile " + car1.GetDistanceTraveled());

            Aircraft plane1 = new Aircraft(100, 1000000, "purple", 600);
            plane1.Move();
            plane1.Move();
            Console.WriteLine("Aircraft " + plane1.GetDistanceTraveled());

            
        }
    }
}
