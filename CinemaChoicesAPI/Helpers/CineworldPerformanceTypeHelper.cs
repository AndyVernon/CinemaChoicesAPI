using CinemaChoicesAPI.Models.Enums;

namespace CinemaChoicesAPI.Helpers
{
    public class CineworldPerformanceTypeHelper
    {
        public CineworldPerformanceType ConvertStringToType(string performanceString)
        {
            switch (performanceString)
            {
                case "reg":
                    return CineworldPerformanceType.Regular;
                case "vip":
                    return CineworldPerformanceType.VIP;
                case "del":
                    return CineworldPerformanceType.Delux;
                case "digital":
                    return CineworldPerformanceType.Digital;
                case "m4j":
                    return CineworldPerformanceType.MoviesForJuniors;
                case "dbox":
                    return CineworldPerformanceType.DBox;
                default:
                    return CineworldPerformanceType.Regular;
            }
        }

    }
}
