﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobovDino
{
    class Dinosaur
    {
        //member variables

        
        public string type;
        public int health;
        public int energy;
        public int attackPower;

        //constructor

        public Dinosaur(string type, int health, int energy, int attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;

        }
        //member methods
        public void AttackRobot(Robot robot)
        {
            Herd theHerd = new Herd();
            

        }


    }
}
