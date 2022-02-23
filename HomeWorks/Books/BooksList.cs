using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.Books
{
//    Задание 3
//Создайте приложение «Список книг для прочтения».
//Приложение должно позволять добавлять книги в список, удалять книги из списка, проверять есть ли книга в
//списке, и т.д.Используйте механизм свойств, перегрузки
//операторов, индексаторов.
    class BooksList
    {
        public static void StartLibrary()
        {

            List<Book> books = new();

            while (true)
            {
                Console.WriteLine("Для добавления книги введите add: ");
                Console.WriteLine("Для удаления книги введите remove: ");
                Console.WriteLine("Для просмотра всех книг введите all: ");

                var choose = Console.ReadLine();

                switch (choose)
                {
                    case "add":

                        Book ex1 = new();
                        Console.Write("Введите автора книги: ");
                        ex1.Author = Console.ReadLine();
                        Console.Write("Введите название книги: ");
                        ex1.Name = Console.ReadLine();
                        Console.Write("Введите год книги: ");
                        ex1.Year = Console.ReadLine();
                        Console.Write("Введите цену книги: ");
                        ex1.Price = Console.ReadLine();
                        books += ex1;
                        break;

                    case "remove":
                        Console.WriteLine("Введите название книги для удаления: ");
                        string forRemove = Console.ReadLine();
                        Book username = books.Find((x) => x.Name == forRemove);
                        books -= username;
                        break;

                    case "all":
                        foreach (var b in books)
                        {
                            Console.WriteLine($"{b.Author} | {b.Name} | {b.Year} | {b.Price}");
                        }
                        break;

                    default:
                        Console.WriteLine("Нету такой операции!");
                        break;
                }
            }
        }

    }

    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }
        public string Price { get; set; }

        public static List<Book> operator +(List<Book> lib, Book book)
        {
            List<Book> l = lib;
            l.Add(book);
            return l;
        }

        public static List<Book> operator -(List<Book> lib, Book book)
        {
            List<Book> l = lib;
            l.Remove(book);
            return l;
        }
    }

}

