using CinemaChoicesAPI.Models.Cinema;
using System.Collections.Generic;
using System.Web.Http;

namespace CinemaChoicesAPI.Controllers
{
    public class CineworldPerformanceController : BaseCineworldController
    {
        [HttpGet]
        [Route("api/CineworldPerformance/GetPerformances/{cinemaid}/{filmedi}/{date}")]
        public IEnumerable<CineworldPerformanceModel> GetPerformances(int cinemaId, int filmEdi, string date)
        {
            return _getCineworldPerformancesList.GetPerformancesForFilm(cinemaId, filmEdi, date);
        }
    }
}
