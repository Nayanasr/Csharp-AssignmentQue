using System;
using System.Collections.Generic;
using System.Text;

namespace AssessmentQue
{
    public class Interface
    {
        interface IAnimal
        {
            void animalSound();
        }

        public class Pig : IAnimal
        {
            public void animalSound()
            {
                Console.WriteLine("The pig saya:wee wee");
            }
        }
    }
}
