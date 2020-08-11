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

        
        public string name;
        public int health;
        public int powerLevel;
        public Weapon Weapon;

        //constructor

        public Robot(string name, int health, int powerLevel, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            
            Weapon particleCannon = new Weapon();
            Weapon antiLizardSpray = new Weapon();
            Weapon freshMeat = new Weapon();
        }
        //member methods
    }
}




            
