using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public abstract class Animal
    {
        public virtual void Sleep() 
        {
            Console.WriteLine("Zzzzzzz");
        }
        public abstract string AnimalType { get; }

        public void DisplayType()
        {
            Console.WriteLine($"This animal is a: {AnimalType}");
        }
        public abstract void Breathe();
        public abstract void Move();
        public virtual void Eat() 
        {
            Console.WriteLine("Eating some good food. Yum");
        }
            
    }
}
