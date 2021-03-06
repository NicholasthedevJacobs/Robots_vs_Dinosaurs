﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobovDino
{
    class Battlefield
    {
        public Fleet theFleet;
        public Herd theHerd;
        int currentRobotAttackerIndex = 0;
        int currentRobotDefenderIndex = 0;
        int currentDinoAttackerIndex = 0;
        int currentDinoDefenderIndex = 0;
        

        public Battlefield()
        {
            theFleet = new Fleet();
            theHerd = new Herd();
        }
        //member methods
        public void DoBattle() // "master" method
        {
           
            while (theHerd.theHerd.Count > 0 && theFleet.theFleet.Count > 0)
            {

                ChooseWhoToAttackRobotPlayer();
                AttackDino();
                IsDeadCheck();
                ChooseWhoToAttackDinoPlayer();
                AttackRobot();
                IsDeadCheck();
            }
            if (theHerd.theHerd.Count == 0 || theFleet.theFleet.Count == 0)
            {
                Console.WriteLine("Game over!");
            }
        }
        public void ChooseWhoToAttackRobotPlayer()
        {
            Console.WriteLine("Choose your attacker!");
            int result = theFleet.DisplayRobotInfo();

            if (result >= 0 && result < theFleet.theFleet.Count)
            {
                theFleet.VerifyChoiceMessageRobo(result);
                currentRobotAttackerIndex = result;

                Console.WriteLine("Choose who to attack!");
                currentDinoDefenderIndex =  theHerd.DisplayDinoInfo();
            }
            else
            {
                Console.WriteLine("invalid");
                ChooseWhoToAttackRobotPlayer();
            }
        }
        public void ChooseWhoToAttackDinoPlayer()
        {
            
            Console.WriteLine("Choose your attacker!");
            int result = theHerd.DisplayDinoInfo();
            
            if (result >= 0 && result < theHerd.theHerd.Count)
            {
                theHerd.VerifyChoiceMessageDino(result);
                currentDinoAttackerIndex = result;

                Console.WriteLine("Choose who to attack!: ");
                currentRobotDefenderIndex = theFleet.DisplayRobotInfo();
            }
            else
            {
                Console.WriteLine("invalid");
                ChooseWhoToAttackDinoPlayer();
            }
        }
        public void AttackDino()
        {

            if (theHerd.theHerd[currentDinoDefenderIndex].health > 0)
            {
                theHerd.theHerd[currentDinoDefenderIndex].health -= theFleet.theFleet[currentRobotAttackerIndex].powerLevel;
                
                
            }   
            else
            {
                
            }  
        }
        public void AttackRobot()
        {
            if (theFleet.theFleet[currentRobotDefenderIndex].health > 0)
            {
                theFleet.theFleet[currentRobotDefenderIndex].health -= theHerd.theHerd[currentDinoAttackerIndex].attackPower;
            }
            else
            {
                
            }
        }
        public void IsDeadCheck()
        {
            if (theHerd.theHerd[currentDinoDefenderIndex].health <= 0)
            {
                Console.WriteLine($"WHAM!! {theHerd.theHerd[currentDinoDefenderIndex]} is Knocked Out!!;");
                theHerd.theHerd.RemoveAt(currentDinoDefenderIndex);
                
            }
            else if (theFleet.theFleet[currentRobotDefenderIndex].health <= 0)
            {
                Console.WriteLine($"WHAM!! {theFleet.theFleet[currentRobotDefenderIndex]} is Knocked Out!!;");
                theFleet.theFleet.RemoveAt(currentRobotDefenderIndex);
            }
            else if (theHerd.theHerd[currentDinoDefenderIndex].health > 0)
            {
                Console.WriteLine($"The defenders health is now {theHerd.theHerd[currentDinoDefenderIndex].health}");
            }
            else if (theFleet.theFleet[currentRobotDefenderIndex].health > 0)
            {
                Console.WriteLine(theFleet.theFleet[currentRobotDefenderIndex].health);
            }
            else
            {
                
            }
           
        }

    }
           
}
                
                
                
                

               
                
                

                

               
                


            




            
                
                
                
         
           
                
            

                

               
            
                
       

