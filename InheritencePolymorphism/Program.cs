﻿using System;
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
            Console.WriteLine("Boat" + boat1.GetDistanceTraveled());
        }
    }
}
