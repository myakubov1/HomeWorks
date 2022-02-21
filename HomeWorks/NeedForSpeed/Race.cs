using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.NeedForSpeed
{
    static class Race
    {
        static Bus Bus = new Bus(40);
        static Cargo Cargo = new Cargo(50);
        static Classic Classic = new Classic(90);
        static Racing Racing = new Racing(140);

        public static void StartRace()
        {   
            Bus.Move();
            Cargo.Move();
            Classic.Move();
            Racing.Move();

        }
    }
}
