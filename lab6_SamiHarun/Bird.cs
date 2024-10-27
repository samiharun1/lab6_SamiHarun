using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_SamiHarun
{
    internal class Bird : Animal
    {
        public double WingSpan { get; set; }

        public Bird(string name = "Lisa", int age = 3, double weight = 0.2, string color = "vit", string habitat = "Skog", double wingspan = 0.5) : base(name, age, weight, color, habitat)  
        {
            WingSpan = wingspan;
            
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} kvittrar: Tweet!");
        }
        public void Fly()
        {
            Console.WriteLine($"{Name} Flyger!");
        }
    }
}
