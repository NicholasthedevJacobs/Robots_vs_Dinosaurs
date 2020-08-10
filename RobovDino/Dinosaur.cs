using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobovDino
{
    class Dinosaur
    {
        //member variables

        Dinosaur dino;
        string type;
        int health;
        int energy;
        int attackPower;

        //constructor

        public Dinosaur(string type, int health, int energy, int attackPower)
        {
            Dinosaur wetnosaur = new Dinosaur("Wetnosaur", 100, 25, 150);
            Dinosaur chomposaur = new Dinosaur("Chomposaur", 300, 40, 60);
            Dinosaur kraken = new Dinosaur("Kraken", 150, 30, 120);
        }
        //member methods



    }
}
