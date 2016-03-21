using CinemaChoicesAPI.Models.Cinema;
using System.Collections.Generic;
using System.Data;

namespace CinemaChoicesAPI.Cineworld
{
    public class GetCineworldPerformancesList : BaseCineworldList
    {
        public IEnumerable<CineworldPerformanceModel> GetPerformancesForFilm(int cinemaId, int filmEdi, string date)
        {
            List<CineworldPerformanceModel> performances = new List<CineworldPerformanceModel>();
            var url = string.Format("http://www2.cineworld.co.uk/api/quickbook/performances?key=nfhMR3xR&cinema={0}&film={1}&date={2}", cinemaId, filmEdi, date);
            var dataTable = _cineworldHelpers.ReadJsonIntoDataTable(url, "performances");
            if (dataTable == null || dataTable.Rows == null || dataTable.Rows.Count == 0)
            {
                return performances;
            }
            foreach (DataRow row in dataTable.Rows)
            {
                CineworldPerformanceModel performance = new CineworldPerformanceModel();
                performance.Time = (string)row[0];
                performance.Available = (bool)row[1];
                performance.Type = (string)row[2];
                performance.AudioDescription = (bool)row[3];
                performance.Subtitled = (bool)row[4];
                performance.BookingUrl = (string)row[6];
                performances.Add(performance);
            }
            return performances;
        }
    }
}
