using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.NeedForSpeed
{
    static class Race
    {
        public static Bus Bus = new Bus(40);
        public static Cargo Cargo = new Cargo(50);
        public static Classic Classic = new Classic(300);
        public static Racing Racing = new Racing(300);
        
        public static void StartRace()
        {
            Bus.Finish += Bus.ShowM;
            Racing.Finish += Racing.ShowM;
            Classic.Finish +=Classic.ShowM;
            Cargo.Finish += Cargo.ShowM;


            while (Car.EndRace != true)
            {

                Bus.Move();
                Cargo.Move();
                Classic.Move();
                Racing.Move();
            }
           
        }
    }
}
