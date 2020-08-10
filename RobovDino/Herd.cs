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
        public string ChooseDinoToUse()
        {
            string dinosaurChoice;
            Console.WriteLine("Commander, choose your Dinosaur Warrior!: ");
            dinosaurChoice = Console.ReadLine();
            return dinosaurChoice;
        }
        public void FindDino(List<Dinosaur> name)
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
    }
}
