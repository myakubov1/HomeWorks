using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.HouseBuilder
{
    class House
    {
        internal House()
        {
            int countParts = 11;
            IPart[] mansionParts = new IPart[countParts];
        }

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

    interface IPart
    {

    }
}
