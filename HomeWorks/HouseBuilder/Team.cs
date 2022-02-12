using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.HouseBuilder
{
    class Team
    {
        internal Team()
        {
            int countWorkers = 5;
            IWorker[] team = new IWorker[countWorkers];
        }



        private House Build()
        {
            House mansion = new House();



            return mansion;
        }

    }
    class Worker : IWorker
    {

    }
    class TeamLeader : IWorker
    {

    }
    interface IWorker
    {

    }
}
