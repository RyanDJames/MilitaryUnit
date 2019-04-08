using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
     public class SmallfireWeapon : Weapons
    {

       new string name = "boo";

        public SmallfireWeapon(string _name) : base(_name)
        {
            name = _name;
        }

       
        public override void reload()
        {
            Console.WriteLine("Drops magazine, and inserts another one");

        }
        public override void shoot()
        {
            Console.WriteLine("pop pop pop");

        }

        public override void misfire()
        {
            Console.WriteLine("Performs POPS");
        }
    }
}
