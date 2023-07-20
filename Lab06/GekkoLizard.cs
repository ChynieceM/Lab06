using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
     class GekkoLizard : Reptile
    {
        public override void Breathe()
        {
            Console.WriteLine("Gecko Breathes!!");
        }
        public override void Sound()
        {
            Console.WriteLine("Hissssss");
        }

        void SellInsurance()
        {
            Console.WriteLine("15 minutes can save you 15 percent or more on car insurance!!");
        }

        public override void Move()
        {
            Console.WriteLine("Wiggles through the forrest");
        }

    }
}
