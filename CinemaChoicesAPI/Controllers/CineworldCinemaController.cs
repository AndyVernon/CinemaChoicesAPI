using CinemaChoicesAPI.Models.Cinema;
using System.Collections.Generic;
using System.Web.Http;

namespace CinemaChoicesAPI.Controllers
{
    /// <summary>
    /// The API methods for Cinemas
    /// </summary>
    public class CineworldCinemaController : BaseCineworldController
    {
        /// <summary>
        /// Gets a list of all cinemas
        /// </summary>
        [HttpGet]
        public IEnumerable<CineworldCinemaModel> GetAllCinemas()
        {
            return _getCineworldCinemasList.GetCinemaList();
        }

        /// <summary>
        /// Gets a list of all cinemas with details including Longitute and Lititude
        /// </summary>
        [HttpGet]
        public IEnumerable<CineworldCinemaModel> GetAllCinemasWithDetails()
        {
            return _getCineworldCinemasList.GetCinemaListWithDetails();
        }
    }
}
