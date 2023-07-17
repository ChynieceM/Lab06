using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class CommodoDragon : Reptile
    {
        public override void Breathe()
        {
            Console.WriteLine("The Dragon BREATHES FIRE!!");
        }
        public override void Sound()
        {
            Console.WriteLine("Dragon ROAR");
        }

        public override void Move()
        {
            Console.WriteLine("Moving forward");
        }

        
    }
}
