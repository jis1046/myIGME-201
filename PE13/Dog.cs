using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE13
{
    internal class Dog : Pet, IDog
    {
        string license;

        public void Eat()
        {
            Console.WriteLine(this.Name + " I am hungry, I want to eat");
        }

        public void Play()
        {
            Console.WriteLine(this.Name + " I want to chew my toy");
        }

        public void Bark()
        {
            Console.WriteLine(this.Name + " Woof woof");
        }

        public void NeedWalk()
        {
            Console.WriteLine(this.Name + " I want to go for walk");
        }

        public void GotoVet()
        {
            Console.WriteLine(this.Name + " No!!! I don't want go to vet@");
        }
    }
}
