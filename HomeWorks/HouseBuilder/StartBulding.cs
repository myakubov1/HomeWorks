using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HomeWorks.HouseBuilder.HouseProject;

namespace HomeWorks.HouseBuilder
{
    class StartBulding
    {
        static public void Start()
        {

            House mansion = new House(parts);
            Team.Build(mansion);
        }

    }
}
