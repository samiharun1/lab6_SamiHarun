using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_SamiHarun
{
    internal class Cat : Animal
    {
        public bool IsIndoorCat { get; set; }

        public Cat(string name = "katt", int age = 7, double weight = 5.0, string color = "Gul", string habitat = "Hus", bool isIndoorCat = true) : base(name, age ,weight ,color , habitat)
        {
            IsIndoorCat = isIndoorCat;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} jamar: Meow!");
        }
        public void Scratch()
        {
            Console.WriteLine($"{Name} klöser!");
        }
    }
}
