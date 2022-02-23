using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.NeedForSpeed
{
    class Classic : Car
    {
        public event CarEvent Finish;
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int Distance { get; set; }
        private Random Random;

        public Classic(int maxSpeed)
        {
            this.Name = "Camry 3.5";
            this.MaxSpeed = maxSpeed;
        }
        public void ShowM()
        {
            Console.WriteLine($"Победитель {Name}");
        }
        public override void Move()
        {
            Random = new Random();
            int DpT = Random.Next(1, MaxSpeed);
            Distance += DpT;

            Console.WriteLine($"{Name}: {Distance}");
            if (Distance >= 1000)
            {
                Finish();
                EndRace = true;
            }
        }
    }
}
