using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Program 
    {
        static void Main(string[] args)
        {
            SmallfireWeapon Rifle = new SmallfireWeapon("M4");
           

            SmallVehicles Humvee = new SmallVehicles("Humvee");

           
            bool war = true;
            while (war)
            {
                Console.WriteLine("Hey do you wanna shoot stuff or drive? type shoot or drive ");
                string input = Console.ReadLine();
                if (input == "shoot")
                {
                    Rifle.shoot();
                    Rifle.misfire();
                    Rifle.reload();
                    
                }
                else if (input == "drive")
                {
                    Humvee.Drive();
                    Humvee.Crash();
                }
                else if (input == "quit")
                {
                    war = false;
                }
                else
                {
                    Console.WriteLine("Sorry m8, didn't catch that. try to choose one of the options." +
                        "\nI know I made it pretty difficult. I mean come on. I gave you TWO WHOLE OPTIONS!" +
                        "\nLike, what am I expecting? You to pick one of the two? You don't listen to the man!" +
                        "\nYou're a poet! A free spirit trying to weave the tapestry of life and spirituality into one beautiful construct!" +
                        "\n You don't have time to pick one of two options!" +
                        "\n... or you could have just capitalised the option you chose..., they're not capitalized and this system is case sensitive.");
                }
            }
        }
    }
}
