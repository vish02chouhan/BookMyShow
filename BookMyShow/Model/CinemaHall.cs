namespace BookMyShow.Model
{
    public class CinemaHall
    {
        public int Id { get; set; }
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }
        public string Name { get; set; }
        public int SeatingCapacity { get; set; }
        public ICollection<Show> Shows { get; set; } = new List<Show>();
    }



}
