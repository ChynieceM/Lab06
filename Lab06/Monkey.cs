using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
     class Monkey : Mammal
    {
        public void ClimbTree()
        {
            Console.WriteLine("Climb!");
        }

        public override void Walk() 
        {
        Console.WriteLine("Walk on paws");
                
        }

        public override void Breathe()
        {
            Console.WriteLine("Im breathing");

        }

        public override void Move()
        {
            Console.WriteLine("Walk on paws");

        }

        
    }
}
