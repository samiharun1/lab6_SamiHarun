using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab6_SamiHarun
{
    internal class Bulldog : Dog
    {
        public Bulldog(string name = "Teo", int age = 4, double weight = 15.0, string color = "Silver", string habitat = "Skog") : base(name, age, weight, color, habitat, breed: "Bulldog")
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} grymtar: GRRRR!");
        }
        public void Snore()
        {
            Console.WriteLine($"{Name} snarkar!");
        }
    }
}
