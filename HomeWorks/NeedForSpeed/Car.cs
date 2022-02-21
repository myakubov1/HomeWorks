using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.NeedForSpeed
{
    public delegate void CarEvent(string Message);

    abstract class Car
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int Distance { get; set; }

        public event CarEvent Finish;
       
        public abstract void Move();
    }
}
