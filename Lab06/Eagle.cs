using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public class Eagle : Bird
    {

        int wingspan = 24; 
        public override void Fly()
        {
            Console.WriteLine("Im flying!");
        }
        public override void Breathe()
        {
            Console.WriteLine("Im breathing");
        }
        public override void Move()
        {
            Console.WriteLine("On the hunt for some dinner");
        }
    }
}
