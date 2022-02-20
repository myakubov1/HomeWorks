using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.NeedForSpeed
{
    abstract class Car
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public Random CurrentSpeed { get; set; }

        public abstract void Move();
    }
}
