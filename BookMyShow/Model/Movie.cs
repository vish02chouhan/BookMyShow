using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ICollection<Show> Shows { get; set; } = new List<Show>();
    }



}
