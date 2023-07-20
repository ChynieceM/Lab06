using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public abstract class Bird : Animal
    {
        int WingSpan;

        public override string AnimalType => "Bird";

        public void DisplayType()
        {
            Console.WriteLine($"This animal is a: {AnimalType}");
        }

        public abstract void Fly();
    }
}
