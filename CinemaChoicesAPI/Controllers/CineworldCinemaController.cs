using CinemaChoicesAPI.Cineworld;
using CinemaChoicesAPI.Models.Cinema;
using System.Collections.Generic;
using System.Web.Http;

namespace CinemaChoicesAPI.Controllers
{
    public class CineworldCinemaController : ApiController
    {
        public IEnumerable<CineworldCinemaModel> GetCinemas()
        {
            List<CineworldCinemaModel> cinemas = new List<CineworldCinemaModel>();
            var test = GetCineworldCinemasList.GetCinemaList();
            return cinemas;
        }
    }
}
