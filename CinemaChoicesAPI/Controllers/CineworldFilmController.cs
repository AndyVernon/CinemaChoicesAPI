using CinemaChoicesAPI.Models.Cinema;
using System.Collections.Generic;
using System.Web.Http;

namespace CinemaChoicesAPI.Controllers
{
    public class CineworldFilmController : BaseCineworldController
    {
        [HttpGet]
        public IEnumerable<CineworldFilmModel> GetAllFilms()
        {
            return _getCineworldFilmsList.GetAllFilms();
        }

        [HttpGet]
        public IEnumerable<CineworldFilmModel> GetFilmsForCinemaByCinemaId(int id)
        {
            return _getCineworldFilmsList.GetFilmsForCinema(id);
        }

        [HttpGet]
        public IEnumerable<CineworldFilmModel> GetFilmsWithDetailsForCinemaByCinemaId(int id)
        {
            return _getCineworldFilmsList.GetFilmsForCinemaWithDetails(id);
        }
    }
}
