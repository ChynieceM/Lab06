using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    abstract class Reptile : Animal
    {
        string ScaleColor;
        int TailSize;
        public abstract void Sound();
    public override string AnimalType => "Reptile";

    public void DisplayType()
    {
        Console.WriteLine($"This animal is a: {AnimalType}");
    }
    }

}
