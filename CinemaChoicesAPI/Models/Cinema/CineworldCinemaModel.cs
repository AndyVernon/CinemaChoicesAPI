using CinemaChoicesAPI.Postcode.Models;

namespace CinemaChoicesAPI.Models.Cinema
{
    public class CineworldCinemaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CinemaUrl { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string Telephone { get; set; }
        public Location Location { get; set; }
    }
}
