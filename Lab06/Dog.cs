using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
     public class Dog : Mammal, IWalk
    {
        public int Legs { get; set; }

        public void Walks()
        {
            Console.WriteLine("Zoooom");
        }
       

        public override void Move()
        {
            Console.WriteLine("moving forward");
        }

        public override void Breathe()
        {
            Console.WriteLine("Im breathing");
        }

        public override void Walk()
        {
            Console.WriteLine("I can walk");
        }

        public override void Sleep()
        {
            Console.WriteLine("I am not asleep, ruff");
        }

        public override void Eat()
        {
            Console.WriteLine("Id like a bone please");
        }
    }
}
