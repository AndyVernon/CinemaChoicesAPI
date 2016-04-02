using CinemaChoicesAPI.Models.Cinema;
using System.Collections.Generic;
using System.Web.Http;

namespace CinemaChoicesAPI.Controllers
{
    /// <summary>
    /// The API methods for Film performances
    /// </summary>
    public class CineworldPerformanceController : BaseCineworldController
    {
        /// <summary>
        /// Gets a list of film performances
        /// </summary>
        /// <param name="cinemaId">The cinema</param>
        /// <param name="filmEdi">The film</param>
        /// <param name="date">The Date</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/CineworldPerformance/GetPerformances/{cinemaid}/{filmedi}/{date}")]
        public IEnumerable<CineworldPerformanceModel> GetPerformances(int cinemaId, int filmEdi, string date)
        {
            return _getCineworldPerformancesList.GetPerformancesForFilm(cinemaId, filmEdi, date);
        }
    }
}
