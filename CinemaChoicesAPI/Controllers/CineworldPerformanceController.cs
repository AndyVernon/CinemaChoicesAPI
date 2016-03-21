using CinemaChoicesAPI.Models.Cinema;
using System.Collections.Generic;

namespace CinemaChoicesAPI.Controllers
{
    public class CineworldPerformanceController : BaseCineworldController
    {
        public IEnumerable<CineworldPerformanceModel> Get(int cinemaId, int filmEdi, string date)
        {
            return _getCineworldPerformancesList.GetPerformancesForFilm(cinemaId, filmEdi, date);
        }
    }
}
