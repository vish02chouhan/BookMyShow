using BookMyShow.Model;
using System;
using System.Collections.Generic;

namespace BookMyShow
{
    internal class PopulateData
    {
        public static List<Cinema> Cinemas = new List<Cinema>();
        public static List<Movie> Movies = new List<Movie>();
        public static List<Show> Shows = new List<Show>();

        public static void PopulateMovieData()
        {
            // Initialize Cinemas
            var cinemaWorld = new Cinema { Name = "Cinema World", Location = "Downtown" };
            var cinemaGalaxy = new Cinema { Name = "Cinema Galaxy", Location = "Uptown" };
            Cinemas.Add(cinemaWorld);
            Cinemas.Add(cinemaGalaxy);

            // Initialize Cinema Halls
            var hallA = new CinemaHall { Name = "Hall A", SeatingCapacity = 100, Cinema = cinemaWorld };
            var hallB = new CinemaHall { Name = "Hall B", SeatingCapacity = 150, Cinema = cinemaWorld };
            var hallC = new CinemaHall { Name = "Hall C", SeatingCapacity = 200, Cinema = cinemaGalaxy };

            cinemaWorld.CinemaHalls = new List<CinemaHall> { hallA, hallB };
            cinemaGalaxy.CinemaHalls = new List<CinemaHall> { hallC };

            // Initialize Movies
            var spaceAdventure = new Movie { Title = "Space Adventure", Genre = "Sci-Fi", Duration = TimeSpan.FromHours(2) };
            var romanticWaves = new Movie { Title = "Romantic Waves", Genre = "Romance", Duration = TimeSpan.FromHours(1.5) };
            Movies.Add(spaceAdventure);
            Movies.Add(romanticWaves);

            // Schedule Shows
            var show1 = new Show { Movie = spaceAdventure, CinemaHall = hallA, StartTime = DateTime.Today.AddHours(14), EndTime = DateTime.Today.AddHours(16) };
            var show2 = new Show { Movie = romanticWaves, CinemaHall = hallB, StartTime = DateTime.Today.AddHours(17), EndTime = DateTime.Today.AddHours(18.5) };
            Shows.Add(show1);
            Shows.Add(show2);

            // Omitted: Implementation of seat creation and assignment to shows
        }
    }
}
