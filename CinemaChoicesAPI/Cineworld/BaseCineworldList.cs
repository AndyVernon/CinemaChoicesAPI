using CinemaChoicesAPI.Helpers;

namespace CinemaChoicesAPI.Cineworld
{
    public class BaseCineworldList
    {
        protected CineworldHelpers _cineworldHelpers;

        public BaseCineworldList()
        {
            _cineworldHelpers = new CineworldHelpers();
        }
    }
}
