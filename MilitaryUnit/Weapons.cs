using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class Weapons
    {
        public string name;

        public Weapons(string _name)
        {
            name = _name;
        }
        
        public virtual void reload()
        {
            Console.WriteLine("Inserts new round into chamber");

        }
        public virtual void shoot()
        {
            Console.WriteLine("brrrratata");

        }

        public virtual void misfire()
        {
            Console.WriteLine("gun dont do nothin it misfired");
        }
    }
}
