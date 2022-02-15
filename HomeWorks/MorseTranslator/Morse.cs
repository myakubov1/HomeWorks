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
        public string Input { get; set; }
        public string Output { get; set; }
        public string Translate(string inputString)
        {
            string output = default;
            char[] alpha = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string[] code = new string[] { "*–", "–***", "*––", "––*",
                                                        "–**", "*", "***–", "––**",
                                                        "**", "*–––", "–*–", "*–**",
                                                        "––", "–*", "–––", "*––*",
                                                        "*–*", "***", "–", "**–",
                                                        "**–*", "****", "–*–*",
                                                        "–––*", "––––", "−−*−",
                                                        "−*−−", "−**−", "**−**",
                                                        "**−−", "*−*−", "*−−−−",
                                                        "**−−−", "***−−", "****−",
                                                        "*****", "−****", "−−***",
                                                        "−−−**", "−−−−*", "−−−−−" };
            int count = 0;

            this.Input = inputString;
            this.Output = output;
            this.Codes = code;
            this.Alphabet = alpha;

            string[] splitted = inputString.Split(' ');

            foreach (string s in splitted)
            {
                count = Array.IndexOf(Codes, s);
                if (count == -1)
                {
                    throw new Exception("Данного символа не существует!");
                }
                Output += Alphabet[count] + " ";
            }
            return Output;
        }
    }
    class RuToMorse : ITranslate
    {
        public char[] Alphabet { get; set; }
        public string[] Codes { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
        public string Translate(string inputString)
        {
            
            string output = default;
            char [] alpha = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string [] code = new string[] { "*–", "–***", "*––", "––*",
                                                        "–**", "*", "***–", "––**",
                                                        "**", "*–––", "–*–", "*–**",
                                                        "––", "–*", "–––", "*––*",
                                                        "*–*", "***", "–", "**–",
                                                        "**–*", "****", "–*–*",
                                                        "–––*", "––––", "−−*−",
                                                        "−*−−", "−**−", "**−**",
                                                        "**−−", "*−*−", "*−−−−",
                                                        "**−−−", "***−−", "****−",
                                                        "*****", "−****", "−−***",
                                                        "−−−**", "−−−−*", "−−−−−" };
            int count = 0;

            this.Input = inputString;
            this.Output = output;
            this.Codes = code;
            this.Alphabet = alpha;

      
            foreach (var c in inputString)
            {
                if (c != ' ')
                {
                    count = Array.IndexOf(Alphabet, char.ToUpper(c));
                    if (count ==-1)
                    {
                        throw new Exception("Данного символа не существует!");
                    }
                    Output += Codes[count] + " ";
                }
            }
            return Output;
        }
    }

}
