using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    abstract class Fish : Animal
    {
        int GillSize;

       
        public void Swim() {

            Console.WriteLine("I am swimming");
        }

        public override string AnimalType => "Fish";

        public void DisplayType()
        {
            Console.WriteLine($"This animal is a: {AnimalType}");
        }

    }
}
