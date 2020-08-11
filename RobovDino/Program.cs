using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobovDino
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fleet fleet = new Fleet();
            //Herd herd = new Herd();
            Battlefield bF = new Battlefield();
            bF.DoBattle();
            
            // bF.ChooseWhoToAttackRobotPlayer();



            //herd.VerifyChoiceMessageDino(1);
            //fleet.VerifyChoiceMessageRobo(1);
            Console.ReadLine();
            
        }
    }
}
