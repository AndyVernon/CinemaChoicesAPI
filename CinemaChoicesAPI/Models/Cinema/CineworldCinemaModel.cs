using CinemaChoicesAPI.Postcode.Models;

namespace CinemaChoicesAPI.Models.Cinema
{
    /// <summary>
    /// The model representing a Cineworld Cinema
    /// </summary>
    public class CineworldCinemaModel
    {
        /// <summary>
        /// The Cinema Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Cinema Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Url for the Cinema
        /// </summary>
        public string CinemaUrl { get; set; }
        
        /// <summary>
        /// The Address of the Cinema
        /// </summary>
        public string Address { get; set; }
        
        /// <summary>
        /// The Postcode for the Cinema
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// The Telephone Number for the Cinema
        /// </summary>
        public string Telephone { get; set; }
        
        /// <summary>
        /// A Location object for the Cinema
        /// </summary>
        public Location Location { get; set; }
    }
}
