using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.HouseBuilder
{
    public class House
    {
        public House(IPart[] parts)
        {
            
        }
    }

    static class HouseProject
    {
        public static IPart Basement { get; set; }
        public static IPart Wall1 { get; set; }
        public static IPart Wall2 { get; set; }
        public static IPart Wall3 { get; set; }
        public static IPart Wall4 { get; set; }
        public static IPart Window1 { get; set; }
        public static IPart Window2 { get; set; }
        public static IPart Window3 { get; set; }
        public static IPart Window4 { get; set; }
        public static IPart Door { get; set; }
        public static IPart Roof { get; set; }

        public static IPart[] houseProject = new IPart[] { Basement, Wall1, Wall2, Wall3, Wall4, Window1, Window2, Window3, Window4, Door, Roof };
    }

    class Basement : IPart
    {
        
    }

    class Walls : IPart
    {
       
    }

    class Door : IPart
    {
        
    }

    class Window : IPart
    {
     
    }

    class Roof : IPart
    {
       
    }

    public interface IPart
    {
        
    }
}
