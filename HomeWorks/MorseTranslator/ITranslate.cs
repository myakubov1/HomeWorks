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
        string Input { get; set; }
        string Output { get; set; }
        void Translate(string pResult)
        {
            this.Output = pResult;
        }
    }
}
