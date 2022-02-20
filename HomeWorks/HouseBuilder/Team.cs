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

        static public void Build(House house)
        {

        }
    }
    class Worker : IWorker
    {
        public void Build()
        {

        }
    }
    class TeamLeader : IWorker
    {
        public void Build()
        {

        }
    }
    interface IWorker
    {
        public void Build()
        {

        }
    }
}
