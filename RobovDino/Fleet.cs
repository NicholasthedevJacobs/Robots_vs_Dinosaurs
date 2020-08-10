using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobovDino
{
    class Fleet
    {
        //member variables
        public Dinosaur dinosaur;
        public List<Robot> theFleet;

        //constructor
        public Fleet()
        {
            theFleet = new List<Robot>();
            Robot hyperSpinningRobo = new Robot("Hyper Spinning Robo", 120, 80, weapon);
            Robot atomicPowerRobot = new Robot("Atomic Power Robot", 300, 75, weapon);
            Robot octobot = new Robot("Octobot", 140, 120, weapon);
            theFleet.Add(hyperSpinningRobo);
            theFleet.Add(atomicPowerRobot);
            theFleet.Add(octobot);
        }

        //member methods
        public void ChooseRobotToUse(string name)
        {
            Console.WriteLine("Commander, choose your Robot Warrior!: ");
        }
        public void ChooseDinosaurEnemy(string name)
        {

        }
    }
}
}
