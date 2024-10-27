using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab6_SamiHarun
{
    internal class Chihuahua : Dog
    {
        public Chihuahua(string name = "Maja", int age = 3, double weight = 2.0, string color = "blå", string habitat = "Lägenhet") : base(name, age, weight, color, habitat, breed: "Chihuahua")
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} skäller: uff uff!");
        }
        public void Shake()
        {
            Console.WriteLine($"{Name} Skakar!");
        } 
        
    }
}
