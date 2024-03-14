using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12_Inheritances_Interfaces
{
    interface IShootable
    {
        string ShotSound { get; set; }

        void Shoot();
    }
}
