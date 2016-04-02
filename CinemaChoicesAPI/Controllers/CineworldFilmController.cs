using CinemaChoicesAPI.Models.Cinema;
using System.Collections.Generic;
using System.Web.Http;

namespace CinemaChoicesAPI.Controllers
{
    /// <summary>
    /// The API methods for Films
    /// </summary>
    public class CineworldFilmController : BaseCineworldController
    {
        /// <summary>
        /// Gets a list of all films
        /// </summary>
        [HttpGet]
        public IEnumerable<CineworldFilmModel> GetAllFilms()
        {
            return _getCineworldFilmsList.GetAllFilms();
        }

        /// <summary>
        /// Gets a list of all films for a cinema
        /// </summary>
        /// <param name="id">The cinema</param>
        [HttpGet]
        public IEnumerable<CineworldFilmModel> GetFilmsForCinemaByCinemaId(int id)
        {
            return _getCineworldFilmsList.GetFilmsForCinema(id);
        }

        /// <summary>
        /// Gets a list of all films for a cinema including details such as Poster Url
        /// </summary>
        /// <param name="id">The cinema</param>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<CineworldFilmModel> GetFilmsWithDetailsForCinemaByCinemaId(int id)
        {
            return _getCineworldFilmsList.GetFilmsForCinemaWithDetails(id);
        }
    }
}
