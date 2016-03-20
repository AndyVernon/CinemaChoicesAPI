using System.Web.Http;

namespace CinemaChoicesAPI.Cineworld
{
    public class BaseCineworldController : ApiController
    {
        protected GetCineworldCinemasList _getCineworldCinemasList;
        protected GetCineworldFilmsList _getCineworldFilmsList;

        public BaseCineworldController()
        {
            _getCineworldCinemasList = new GetCineworldCinemasList();
            _getCineworldFilmsList = new GetCineworldFilmsList();
        }
    }
}
