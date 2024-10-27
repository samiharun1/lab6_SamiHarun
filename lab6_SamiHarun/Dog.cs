using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_SamiHarun
{
    internal class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name = "Sami", int age = 3, double weight = 10.0, string color = "Brun", string habitat = "Hus", string breed = "Blandras") 
        {
            Name = name;
            Age = age;
            Weight = weight;
            Color = color;
            Habitat = habitat;
            Breed = breed;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} skäller: WOOF!");
        }
        public void Fetch ()
        {
            Console.WriteLine($"{Name} hämtar en Pinne!");

        }

    }
}
