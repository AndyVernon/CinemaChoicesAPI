using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaChoicesAPI.Postcode.Models
{
    /// <summary>
    /// An object containing the Longitude and Latitude obtained from a Postcode
    /// </summary>
    public class Location
    {
        /// <summary>
        /// The Longitude
        /// </summary>
        public string Longitude { get; set; }

        /// <summary>
        /// The Latitude
        /// </summary>
        public string Latitude { get; set; }
    }
}
