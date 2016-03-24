using CinemaChoicesAPI.Cineworld;
using CinemaChoicesAPI.Models.Cinema;
using System.Collections.Generic;

namespace CinemaChoicesAPI.Controllers
{
    public class CineworldFilmController : BaseCineworldController
    {
        public IEnumerable<CineworldFilmModel> Get(int id)
        {
            return _getCineworldFilmsList.GetFilmsForCinema(id);
        }

        public IEnumerable<CineworldFilmModel> GetDetails(int id)
        {
            return _getCineworldFilmsList.GetFilmsForCinemaWithDetails(id);
        }

        public IEnumerable<CineworldFilmModel> Get()
        {
            return _getCineworldFilmsList.GetAllFilms();
        }

    }
}
