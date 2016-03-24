using CinemaChoicesAPI.Cineworld;
using CinemaChoicesAPI.Models.Cinema;
using System.Collections.Generic;
using System.Web.Http;

namespace CinemaChoicesAPI.Controllers
{
    public class CineworldCinemaController : BaseCineworldController
    {
        [HttpGet]
        public IEnumerable<CineworldCinemaModel> GetAllCinemas()
        {
            return _getCineworldCinemasList.GetCinemaList();
        }

        [HttpGet]
        public IEnumerable<CineworldCinemaModel> GetAllCinemasWithDetails()
        {
            return _getCineworldCinemasList.GetCinemaListWithDetails();
        }
    }
}
