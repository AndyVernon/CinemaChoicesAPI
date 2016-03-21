using CinemaChoicesAPI.Cineworld;
using System.Web.Http;

namespace CinemaChoicesAPI.Controllers
{
    public class BaseCineworldController : ApiController
    {
        protected GetCineworldCinemasList _getCineworldCinemasList;
        protected GetCineworldFilmsList _getCineworldFilmsList;
        protected GetCineworldPerformancesList _getCineworldPerformancesList;

        public BaseCineworldController()
        {
            _getCineworldCinemasList = new GetCineworldCinemasList();
            _getCineworldFilmsList = new GetCineworldFilmsList();
            _getCineworldPerformancesList = new GetCineworldPerformancesList();
        }
    }
}
