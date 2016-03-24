using CinemaChoicesAPI.Helpers;
using CinemaChoicesAPI.Postcode;

namespace CinemaChoicesAPI.Cineworld
{
    public class BaseCineworldList
    {
        protected CineworldHelpers _cineworldHelpers;
        protected PostcodeApiReader _postcodeApiReader;

        public BaseCineworldList()
        {
            _cineworldHelpers = new CineworldHelpers();
            _postcodeApiReader = new PostcodeApiReader(_cineworldHelpers);
        }
    }
}
