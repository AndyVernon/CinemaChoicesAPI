using System.Collections.Generic;
using CinemaChoicesAPI.Models.Cinema;
using System.Data;
using System;

namespace CinemaChoicesAPI.Cineworld
{
    public class GetCineworldCinemasList : BaseCineworldList
    {  
        public IEnumerable<CineworldCinemaModel> GetCinemaList()
        { 
            List<CineworldCinemaModel> cinemas = new List<CineworldCinemaModel>();
            var url = "http://www.cineworld.com/api/quickbook/cinemas?key=nfhMR3xR";
            var dataTable = _cineworldHelpers.ReadJsonIntoDataTable(url, "cinemas");
            foreach (DataRow row in dataTable.Rows)
            {
                CineworldCinemaModel cinema = new CineworldCinemaModel();
                cinema.Id = Convert.ToInt32(row[0]);
                cinema.Name = (string)row[1];
                cinema.CinemaUrl = (string)row[2];
                cinemas.Add(cinema);
            }
            return cinemas;
        }
    }
}
