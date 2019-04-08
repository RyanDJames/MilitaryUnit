using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class SmallVehicles: Vehicles
    {
        new string name = "boo";

        public SmallVehicles(string _name) : base(_name)
        {
            name = _name;
        }


        public override void Drive()
        {
            Console.WriteLine("Skrrrt");

        }
        public override void Crash()
        {
            Console.WriteLine("Snap, Crackle, pop");

        }
    }
}
