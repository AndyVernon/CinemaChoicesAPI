using CinemaChoicesAPI.Cineworld;
using CinemaChoicesAPI.Models.Cinema;
using System.Collections.Generic;

namespace CinemaChoicesAPI.Controllers
{
    public class CineworldCinemaController : BaseCineworldController
    {
        public IEnumerable<CineworldCinemaModel> Get()
        {
            return _getCineworldCinemasList.GetCinemaList();
        }

        
    }
}
