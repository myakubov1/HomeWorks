using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.MorseTranslator
{
    class Morse
    {
        //public Morse()
        //{
        //    ITranslate MtR = new MorseToRu();
        //    MtR.Alphabet = new char[] { 'А' };
        //    MtR.Codes = new string[] { "*–" };
        //    MtR.Translate();
        //}
    }

    class MorseToRu : ITranslate
    {
        public char[] Alphabet { get; set; }
        public string[] Codes { get; set; }
        public void Translate()
        {
            
            Alphabet[0] = 'z';
            Codes[0] = "Z";
           
        }
    }
    class RuToMorse : ITranslate
    {
        public char[] Alphabet { get; set; }
        public string[] Codes { get; set; }
        public void Translate()
        {

        }
    }

}
