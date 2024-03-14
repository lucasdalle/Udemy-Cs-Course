using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12_Inheritances_Interfaces
{
    class Weapon
    {
        public string Name { get; set; }

        public Weapon() 
        {
            Name = "UnknowWeapon";
        }

        public Weapon(string name) 
        {
            Name = name; 
        }

        public void Label()
        {
            Console.WriteLine($"This is {this.Name}!");
        }
    }
}
