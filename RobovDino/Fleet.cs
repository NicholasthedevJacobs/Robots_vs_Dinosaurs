﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobovDino
{
    class Fleet
    {
        //member variables
        //public Dinosaur dinosaur;
        public List<Robot> theFleet;
        

        //constructor
        public Fleet()
        {
            Weapon weapon = new Weapon();
            theFleet = new List<Robot>();
            Robot hyperSpinningRobo = new Robot("Hyper Spinning Robo", 120, 80, weapon);
            Robot atomicPowerRobot = new Robot("Atomic Power Robot", 300, 75, weapon);
            Robot octobot = new Robot("Octobot", 140, 120, weapon);
            theFleet.Add(hyperSpinningRobo);
            theFleet.Add(atomicPowerRobot);
            theFleet.Add(octobot);
        }

        //member methods
        public int DisplayRobotInfo()
        {
            
            if (theFleet.Count > 0)
            {
                Console.WriteLine("Press 1: to choose " + theFleet[0].name);
                Console.Write("HEALTH: " + theFleet[0].health + " ");
                Console.WriteLine("ATTACK POWER: " + theFleet[0].powerLevel);
                Console.WriteLine("  --------------------------");
                if (theFleet.Count > 1)
                {
                    Console.WriteLine("Press 2: to choose " + theFleet[1].name);
                    Console.Write("HEALTH: " + theFleet[1].health + " ");
                    Console.WriteLine("ATTACK POWER: " + theFleet[1].powerLevel);
                    Console.WriteLine("  --------------------------");
                    if (theFleet.Count > 2)
                    {
                        Console.WriteLine("Press 3: to choose " + theFleet[2].name);
                        Console.Write("HEALTH: " + theFleet[2].health + " ");
                        Console.WriteLine("ATTACK POWER: " + theFleet[2].powerLevel);
                        Console.WriteLine("  --------------------------");
                    }
                }
            }
           
            return int.Parse(Console.ReadLine()) - 1;

          

        }
        public void VerifyChoiceMessageRobo(int nameOfChosenRobot)
        {
            
            Console.WriteLine($"Great choice commander, you have chosen {theFleet[nameOfChosenRobot].name}: ");
           
        }
        public void ChooseDinosaurEnemy(string name)
        {

        }
    }
}

