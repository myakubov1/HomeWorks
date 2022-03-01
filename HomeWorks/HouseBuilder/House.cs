using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.HouseBuilder
{
    public class House
    {
        public List<IPart> HouseProject { get; set; }
        public House(List<IPart> houseProject)
        {
            this.HouseProject = houseProject;
        }
    }

    public static class HouseProject
    {

        public static List<IPart> parts = new List<IPart>
        {
            new Basement(),
            new Walls(),
            new Walls(),
            new Walls(),
            new Walls(),
            new Window(),
            new Window(),
            new Window(),
            new Window(),
            new Door(),
            new Roof()
        };
    }



    public class Basement : IPart
    {
        public Basement()
        {
            Completed = false;
            CurrentPart = "Фундамент";
        }
        public string CurrentPart { get; set; }
        public bool Completed { get; set; }
    }

    public class Walls : IPart
    {
        public Walls()
        {
            Completed = false;
            CurrentPart = "Стена";
        }
        public string CurrentPart { get; set; }
        public bool Completed { get; set; }
    }

    public class Door : IPart
    {
        public Door()
        {
            Completed = false;
            CurrentPart = "Дверь";
        }
        public string CurrentPart { get; set; }
        public bool Completed { get; set; }
    }

    public class Window : IPart
    {
        public Window()
        {
            Completed = false;
            CurrentPart = "Окно";
        }
        public string CurrentPart { get; set; }
        public bool Completed { get; set; }
    }

    public class Roof : IPart
    {
        public Roof()
        {
            Completed = false;
            CurrentPart = "Крыша";
        }
        public string CurrentPart { get; set; }
        public bool Completed { get; set; }

    }

    public interface IPart
    {
        public string CurrentPart { get; set; }
        public bool Completed { get; set; }

    }
}
