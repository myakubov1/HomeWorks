using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.Films
{
    public class Films
    {
        public string Name { get; set; }
        public decimal BoxOffice { get; set; }
        public enum Genre
        {
            Horror,
            Comedy,
            Detective,
            Cartoon,
            Action
        }

        public Genre genre { get; set; }
        public Films(string Name, decimal BoxOffice, Genre Gener)
        {
            this.Name = Name;
            this.BoxOffice = BoxOffice;
            this.genre = Gener;
        }
       
    }
}
