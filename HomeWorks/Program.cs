﻿using System;
using HomeWorks.MorseTranslator;
using HomeWorks.Books;
using HomeWorks.HouseBuilder;
using System.IO;
using System.Text;
using static HomeWorks.HouseBuilder.StartBulding;
using static HomeWorks.NeedForSpeed.Race;
using System.Collections.Generic;

namespace HomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {

            ////BooksList.StartLibrary();

            //RuToMorse RtM = new RuToMorse();
            //Console.WriteLine("Введите слово на русской раскладке: ");
            //var outp = RtM.Translate(Console.ReadLine());
            //Console.WriteLine(outp);

            //Console.WriteLine("Введите код в Азбуке Морзе (каждый символ через пробел): ");
            //MorseToRu MtR = new MorseToRu();
            //var outp2 = MtR.Translate(Console.ReadLine());
            //Console.WriteLine(outp2);

            //Start();



                Console.WriteLine("--------------------");
                StartRace();

            //List<string> stringArray = new List<string>();
            //string inputedString = "";
            //while ((inputedString = Console.ReadLine()) != "")
            //{

            //    stringArray.Add(inputedString);

            //}
            //foreach (string s in stringArray)
            //{
            //    Console.WriteLine(s);
            //}
            //stringArray.Clear();

            //List<string> list = new List<string>();
            //list.Add("1");
            //list.Add("2");

            //foreach (string i in list)
            //{
            //    Console.WriteLine(i);
            //}
        }


    }
}
