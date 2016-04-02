using CinemaChoicesAPI.Helpers;
using CinemaChoicesAPI.Models.Enums;

namespace CinemaChoicesAPI.Models.Cinema
{
    /// <summary>
    /// The model representing a Cineworld Film Performance
    /// </summary>
    public class CineworldPerformanceModel
    {
        private CineworldPerformanceTypeHelper _helper;

        /// <summary>
        /// Constructor method that instanciates an instance of CineworldPerformanceTypeHelper
        /// </summary>
        public CineworldPerformanceModel()
        {
            _helper = new CineworldPerformanceTypeHelper();
        }

        /// <summary>
        /// The Performance time
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// If the Performance is available
        /// </summary>
        public bool Available { get; set; }
        
        /// <summary>
        /// The Performance type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// If the Performance is audio description
        /// </summary>
        public bool AudioDescription { get; set; }

        /// <summary>
        /// If the Performance is subtitled
        /// </summary>
        public bool Subtitled { get; set; }

        /// <summary>
        /// The Performance booking Url
        /// </summary>
        public string BookingUrl { get; set; }

        /// <summary>
        /// The Performance CineworldPerformanceType
        /// </summary>
        public CineworldPerformanceType PerformanceType
        {
            get
            {
                return _helper.ConvertStringToType(Type);
            }
        }
    }
}
