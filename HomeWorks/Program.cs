using System;
using HomeWorks.MorseTranslator;
using HomeWorks.Books;
namespace HomeWorks
{
    class Program
    {
//        Задание 3
//Создайте приложение для перевода обычного текста
//в азбуку Морзе.Пользователь вводит текст.Приложение
//отображает введенный текст азбукой Морзе.Используйте
//механизмы пространств имён.
//Задание 4
//Добавьте к предыдущему заданию механизм перевода
//текста из азбуки Морзе в обычный текст
        static void Main(string[] args)
        {
            //BooksList.StartLibrary();

            RuToMorse RtM = new RuToMorse();


            Console.WriteLine("Введите слово на русской раскладке: ");
            var outp = RtM.Translate(Console.ReadLine());
            Console.WriteLine(outp);


            Console.WriteLine("Введите код в Азбуке Морзе (каждый символ через пробел): ");
            MorseToRu MtR = new MorseToRu();
            var outp2 = MtR.Translate(Console.ReadLine());
            Console.WriteLine(outp2);


        }
    }
}
