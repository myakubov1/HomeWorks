using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.Films
{
    class ShowFilms
    {
        public static void Show()
        {

            List<Films> allFilms = new List<Films>();
            allFilms.Add(new Films("Абра-Кадабра", 100m, Films.Genre.Cartoon));
            allFilms.Add(new Films("Человек паук", 10321.30m, Films.Genre.Comedy));
            allFilms.Add(new Films("Яблоко", 999.00m, Films.Genre.Comedy));
            allFilms.Add(new Films("Свинячий патруль", 120.2m, Films.Genre.Comedy));
            allFilms.Add(new Films("1001 Ночь", 2410.30m, Films.Genre.Action));
            allFilms.Add(new Films("101 Долматинец", 100m, Films.Genre.Horror));
            allFilms.Add(new Films("Король-лев", 33331.100m, Films.Genre.Detective));
            allFilms.Add(new Films("Настоящий детектив", 3003331.100m, Films.Genre.Detective));
            allFilms.Add(new Films("Ужастик", 4211.36m, Films.Genre.Horror));
            allFilms.Add(new Films("Ужастик 2", 5331.100m, Films.Genre.Horror));
            var orderedByName = allFilms.OrderBy(i => i.Name);
            var orderedByBoxOfficeDesc = allFilms.OrderByDescending(i => i.BoxOffice);
            var orderedByGenreAsc = allFilms.OrderBy(i => i.genre.ToString());
            var orderedByHorrors = allFilms.Where(i => i.genre == Films.Genre.Horror).OrderBy(i => i.genre);

            Output(orderedByName, "Соритровка по имени");
            Output(orderedByBoxOfficeDesc, "Соритровка по убыванию кассовых сборов");
            Output(orderedByHorrors, "Фильтрация по жанру ужасы");
            Output(orderedByGenreAsc, "Сортировка по имени жанра");

        }


        static void Output(IOrderedEnumerable<Films> elements, string typeSort)
        {
            Console.WriteLine("-----------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(typeSort);
            Console.ResetColor();
            foreach (var f in elements)
            {
                Console.WriteLine($"{f.Name}  |  {f.BoxOffice}  |  {f.genre}");
            }
            Console.WriteLine("-----------------------");
        }
       
    }
}
