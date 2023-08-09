﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public class Eagle : Bird, IWalk
    {

        int wingspan = 24;

        public int Legs { get; set; }

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

        public void Walk()
        {
            Console.WriteLine("Cawwww Cawwww");
        }

        public void Walks()
        {
            Console.WriteLine("Walking again");
        }
    }
}
