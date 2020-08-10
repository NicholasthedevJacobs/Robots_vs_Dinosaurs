using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobovDino
{
    class Herd

    {
        //member variables
        public List<Dinosaur> theHerd;

        //constructor
        public Herd()
        {

            Dinosaur wetnosaur = new Dinosaur("Wetnosaur", 100, 25, 150);
            Dinosaur chomposaur = new Dinosaur("Chomposaur", 300, 40, 60);
            Dinosaur kraken = new Dinosaur("Kraken", 150, 30, 120);
            theHerd.Add(wetnosaur);
            theHerd.Add(chomposaur);
            theHerd.Add(kraken);
        }

        //member methods
        public int DisplayDinoInfo()
        {
            Console.WriteLine("Press 1: to choose " + theHerd[0].type);
            Console.WriteLine("Press 2: to choose " + theHerd[1].type);
            Console.WriteLine("Press 3: to choose " + theHerd[2].type);
           return int.Parse(Console.ReadLine()) -1;

           // Dinosaur AttackingDino = theHerd[userInput - 1];

        }
       
        public void FindDino(string name)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (theHerd[i].type == )
                {

                }
            }

        }
        public void ChooseRobotEnemy(string name)
        {

        }
        //public Dinosaur ChooseDinoToUse()
        //{   
        //      ~~***Became unneccesary, but keeping for now as reference***~~
        //    Console.WriteLine("Commander, choose your Dinosaur Warrior!: ");
        //    int userInput = DisplayDinoInfo();
        //    Dinosaur AttackingDino = theHerd[userInput - 1];
        //    return AttackingDino;
        //}
    }
}
