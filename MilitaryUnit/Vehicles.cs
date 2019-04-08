using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class Vehicles
    {
        public string name;

        public Vehicles(string _name)
        {
            name = _name;
        }

        public virtual void Drive()
        {
            Console.WriteLine("vroom");
        }
        public virtual void Crash()
        {
            Console.WriteLine("ahhhhh");
        }
    }
}
