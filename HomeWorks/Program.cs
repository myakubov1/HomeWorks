using System;
using HomeWorks.MorseTranslator;
using HomeWorks.Books;
using HomeWorks.HouseBuilder;
using System.IO;
using System.Text;

using static HomeWorks.NeedForSpeed.Race;
using System.Collections.Generic;
using System.Linq;
using static HomeWorks.Films.Films; 
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


            //StartBulding.Start();

            //Console.WriteLine("--------------------");
            //StartRace();

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


            //Student[] students = {
            //new Student("bob", 5),
            //new Student("alice", 1),
            //new Student("max", 3),
            //new Student("andrew", 4),
            //new Student("john", 4)
            //};

            //IEnumerable<string> name =
            //    from s in students
            //    where s.Grade >= 4
            //    orderby s.Name
            //    select s.Name;


            //foreach (var c in name)
            //{
            //    Console.WriteLine(c);
            //}


            //Worker worker1 = new Worker("Борис", new string[] {"Настроить доступ","Починить наушник", "Заменить провод" });
            //Worker worker2 = new Worker("Глеб", new string[] { "Написать триггеры", "Настроить репликацию" });
            //Worker worker3 = new Worker("Полина", new string[] { "Совещание", "Оценить сотрудников" });
            //Worker[] workers = new Worker[] { worker1, worker2, worker3 };
            //foreach (var w in workers)
            //{
            //    foreach(var c in w.Jobs)
            //    {
            //        Console.WriteLine($"{w.Name} | {c}");
            //    }
            //}


            Films.ShowFilms.Show();
           
        }
        //class Student
        //{
        //    public string Name { get; set; }
        //    public int Grade { get; set; }
        //    public Student(string name, int grade)
        //    {
        //        this.Grade = grade;
        //        this.Name = name;
        //    }
        //}

        //public class Worker
        //{
        //    public string Name { get; set; }
        //    public string[] Jobs { get; set; }

        //    public Worker(string Name, string[] Jobs)
        //    {
        //        this.Name = Name;
        //        this.Jobs = Jobs;
        //    }
        //}
    }
}
