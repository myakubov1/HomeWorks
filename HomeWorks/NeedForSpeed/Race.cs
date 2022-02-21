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
        public static Classic Classic = new Classic(90);
        public static Racing Racing = new Racing(140);
        public static bool EndRace { get; set; }
        public static void StartRace()
        {
            Bus.Finish += () => AllOver(Bus.Name);
            Cargo.Finish += () => AllOver(Cargo.Name);
            Classic.Finish += () => AllOver(Classic.Name);
            Racing.Finish += () => AllOver(Racing.Name);

            Bus.Move();
            Cargo.Move();
            Classic.Move();
            Racing.Move();


        }

        public static void AllOver(string carName)
        {
            Console.WriteLine($"Все, приехали! Победитель {carName}");
            EndRace = true;
        }
    }
}
