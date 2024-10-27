using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_SamiHarun
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string Habitat { get; set; }

        public Animal(string name = "Okänd djur", int age = 0, double weight = 0.0, string color = "Okänd", string habitat = "Okänd") 
        {
            Name = name;
            Age = age;
            Weight = weight;
            Color = color;
            Habitat = habitat;
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} äter");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} sover");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} gör ett ljud");
        }


        }

}
