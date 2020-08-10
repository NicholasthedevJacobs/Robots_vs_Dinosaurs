using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobovDino
{
    class Battlefield
    {
        public Fleet theFleet;
        public Herd theHerd;

        public Battlefield()
        {
            Fleet theFleet = new Fleet();
            Herd theHerd = new Herd();

            
        }


        //member methods
        public string ChooseWhoToAttack()
        {
            
            if (theFleet.DisplayRobotInfo() == 0 || theFleet.DisplayRobotInfo() == 1 || theFleet.DisplayRobotInfo() == 2)
            {
                Console.WriteLine(theHerd.DisplayDinoInfo());
                string defenderChoice = Console.ReadLine();
                return defenderChoice;
            }
            else
            {
                Console.WriteLine(theFleet.DisplayRobotInfo());
                string defenderChoice = Console.ReadLine();
                return defenderChoice;
            }
        }
        public int Attack()
        {
            int someVariable = TheHerd.DisplayDinoInfo();
            TheFleet.theFleet[someVariable].Attack(TheHerd.theHerd[0]);
        }
    }
}
