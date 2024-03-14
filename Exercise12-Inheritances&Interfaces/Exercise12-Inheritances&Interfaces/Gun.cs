using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12_Inheritances_Interfaces
{
    class Gun : Weapon, IShootable
    {
        public string ShotSound { get; set; }
        
        public Gun() 
        {
            this.Name = "Gun";
            this.ShotSound = "Bang!";
        }

        public Gun(string name)
        {
            this.Name = name;
            this.ShotSound = "Bang!";
        }

        public void Shoot()
        {
            Console.WriteLine(ShotSound);
        }
    }
}
