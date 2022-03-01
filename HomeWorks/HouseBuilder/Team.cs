using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HomeWorks.HouseBuilder.HouseProject;

namespace HomeWorks.HouseBuilder
{
    static class Team
    {
        public static IWorker TeamLeader { get; set; }
        public static IWorker Worker1 { get; set; }
        public static IWorker Worker2 { get; set; }
        public static IWorker Worker3 { get; set; }
        public static IWorker Worker4 { get; set; }

        public static IWorker[] team = new IWorker[] { TeamLeader, Worker1, Worker2, Worker3, Worker4 };

        public static bool BuildEnd { get; set; }
        static public void Build(House house)
        {
            while (BuildEnd != true)
            {
                //foreach (var c in house)
                //{

                //}
            }

        }
    }
    class Worker : IWorker
    {
        public void Work()
        {

        }
    }
    class TeamLeader : IWorker
    {
        public void Work()
        {

        }
    }
    interface IWorker
    {
        public void Work()
        {

        }
    }
}
