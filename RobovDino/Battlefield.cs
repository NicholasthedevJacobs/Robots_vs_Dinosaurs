using System;
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
        int currentRobotAttackerIndex;
        int currentRobotDefenderIndex;
        int currentDinoAttackerIndex;
        int currentDinoDefenderIndex;

        public Battlefield()
        {
            theFleet = new Fleet();
            theHerd = new Herd();

            
        }


        //member methods
        public void DoBattle() // "master" method
        {
            currentRobotAttackerIndex = ChooseWhoToAttackRobotPlayer();
            currentDinoDefenderIndex = AttackDino();
            IsDeadCheck();
            // call your method that lets a robo attack a dino
            // call your check it dead

            currentDinoAttackerIndex = ChooseWhoToAttackDinoPlayer();
            currentRobotDefenderIndex = AttackRobot();
            IsDeadCheck();
            // call your method that lets a dino attack a robo
            // call your check it dead




        }

        public int ChooseWhoToAttackRobotPlayer()
        {
            Console.WriteLine("Choose your attacker!");
            int result = theFleet.DisplayRobotInfo();

            if (result >= 0 && result < theFleet.theFleet.Count)
            {
                theFleet.VerifyChoiceMessageRobo(result);
                currentRobotAttackerIndex = result;

                Console.WriteLine("Choose who to attack!");
                int defender = theHerd.DisplayDinoInfo();
                
                theHerd.VerifyChoiceMessageDino(defender);

                return defender;
                
            }
            else
            {
                Console.WriteLine(theFleet.DisplayRobotInfo());
                int defenderChoice = int.Parse(Console.ReadLine());
                return defenderChoice;
            }
        }
                
                
        public int ChooseWhoToAttackDinoPlayer()
        {
            
            Console.WriteLine("Choose your attacker!");
            int result = theHerd.DisplayDinoInfo();
            
            if (result >= 0 && result < theHerd.theHerd.Count)
            {
                theHerd.VerifyChoiceMessageDino(result);
                currentDinoAttackerIndex = result;

                Console.WriteLine("Choose who to attack!: ");
                int defender = theFleet.DisplayRobotInfo();

                theFleet.VerifyChoiceMessageRobo(defender);
                
                return defender;

            }
            else
            {
                Console.WriteLine(theFleet.DisplayRobotInfo());
                int defenderChoice = int.Parse(Console.ReadLine());
                return defenderChoice;
            }
        }
                
        public int AttackDino()
        {

            if (theHerd.theHerd[currentDinoDefenderIndex].health > 0)
            {
                theHerd.theHerd[currentDinoDefenderIndex].health -= theFleet.theFleet[currentRobotAttackerIndex].powerLevel;
                int thestuff1 = theHerd.theHerd[currentDinoDefenderIndex].health;
                return thestuff1;
            }   
            else
            {
                return 0;
            }
        }
        public int AttackRobot()
        {
            if (theFleet.theFleet[currentRobotDefenderIndex].health > 0)
            {
                theFleet.theFleet[currentRobotDefenderIndex].health -= theHerd.theHerd[currentDinoAttackerIndex].attackPower;
                int thestuff = theFleet.theFleet[currentRobotDefenderIndex].health;
                return thestuff;
            }
            else
            {
                return 0;
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
                Console.WriteLine(theHerd.theHerd[currentDinoDefenderIndex].health);
            }
            else if (theFleet.theFleet[currentRobotDefenderIndex].health > 0)
            {
                Console.WriteLine(theFleet.theFleet[currentRobotDefenderIndex].health);
            }

        }

    }
           
}
         
           
                
            

                

               
            
                
       

