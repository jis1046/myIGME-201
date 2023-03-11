using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE13
{
    internal class Cat: Pet, ICat
    {
        public Cat() 
        { 
        
        }
        public void Eat()
        {
            Console.WriteLine(this.Name + " Meow, I want to eat");
        }

        public void Play()
        {
            Console.WriteLine(this.Name + " I want to play yarn");
        }

        public void Purr()
        {
            Console.WriteLine(this.Name + " Purrrrr");
        }

        public void Scratch()
        {
            Console.WriteLine(this.Name + " I want to scratch the wall");
        }

        public void GotoVet()
        {
            Console.WriteLine(this.Name + " Try to take me to vet then you will go to hell");
        }
    }
}
