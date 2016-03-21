using CinemaChoicesAPI.Helpers;
using CinemaChoicesAPI.Models.Enums;

namespace CinemaChoicesAPI.Models.Cinema
{
    public class CineworldPerformanceModel
    {
        private CineworldPerformanceTypeHelper _helper;

        public CineworldPerformanceModel()
        {
            _helper = new CineworldPerformanceTypeHelper();
        }

        public string Time { get; set; }
        public bool Available { get; set; }
        public string Type { get; set; }
        public bool AudioDescription { get; set; }
        public bool Subtitled { get; set; }
        public string BookingUrl { get; set; }
        
        public CineworldPerformanceType PerformanceType
        {
            get
            {
                return _helper.ConvertStringToType(Type);
            }
        }
    }
}
