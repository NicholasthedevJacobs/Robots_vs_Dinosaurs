using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobovDino
{
    class Robot
    {
        //member variables

        Robot robot;
        string name;
        int health;
        int powerLevel;
        Weapon Weapon;

        //constructor

        public Robot(string name, int health, int powerLevel, Weapon weapon)
        {
            Robot hyperSpinningRobo = new Robot("Hyper Spinning Robo", 120, 80, weapon);
            Robot atomicPowerRobot = new Robot("Atomic Power Robot", 300, 75, weapon);
            Robot octobot = new Robot("Octobot", 140, 120, weapon);
        }
        //member methods


    }
}
