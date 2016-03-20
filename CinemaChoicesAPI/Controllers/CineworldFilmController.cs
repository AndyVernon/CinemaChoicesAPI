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
    }
}
