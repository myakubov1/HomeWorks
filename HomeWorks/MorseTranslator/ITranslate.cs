using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.MorseTranslator
{
    interface ITranslate
    {
        char[] Alphabet { get; set; }
        string[] Codes { get; set; }
        void Translate();
    }
}
