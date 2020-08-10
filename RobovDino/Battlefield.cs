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
            theFleet = new Fleet();
            theHerd = new Herd();

            
        }


        //member methods
        public int ChooseWhoToAttack()
        {
            //int defenderChoice = 0;
            if (theFleet.DisplayRobotInfo() == 0 || theFleet.DisplayRobotInfo() == 1 || theFleet.DisplayRobotInfo() == 2)
            {
                Console.WriteLine(theHerd.DisplayDinoInfo());
                int defenderChoice = int.Parse(Console.ReadLine());
                return defenderChoice;
            }
            else
            {
                Console.WriteLine(theFleet.DisplayRobotInfo());
                int defenderChoice = int.Parse(Console.ReadLine());
                return defenderChoice;
            }
        }
        //public int Attack()
        //{
        //    int someVariable = TheHerd.DisplayDinoInfo();
        //    TheFleet.theFleet[someVariable].Attack(TheHerd.theHerd[0]);
        //}
    }
}
