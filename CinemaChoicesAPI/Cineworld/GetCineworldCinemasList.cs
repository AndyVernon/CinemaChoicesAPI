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
                cinema.Id = _cineworldHelpers.GetColumnValueAsIntegerOrZero(row, 0);
                cinema.Name = _cineworldHelpers.GetColumnValueAsStringOrEmptyString(row, 1);
                cinema.CinemaUrl = _cineworldHelpers.GetColumnValueAsStringOrEmptyString(row, 2);
                cinemas.Add(cinema);
            }
            return cinemas;
        }

        public IEnumerable<CineworldCinemaModel> GetCinemaListWithDetails()
        {
            List<CineworldCinemaModel> cinemas = new List<CineworldCinemaModel>();
            var url = "http://www.cineworld.com/api/quickbook/cinemas?key=nfhMR3xR&full=true";
            var dataTable = _cineworldHelpers.ReadJsonIntoDataTable(url, "cinemas");
            foreach (DataRow row in dataTable.Rows)
            {
                CineworldCinemaModel cinema = new CineworldCinemaModel();
                cinema.Id = _cineworldHelpers.GetColumnValueAsIntegerOrZero(row, 0);
                cinema.Name = _cineworldHelpers.GetColumnValueAsStringOrEmptyString(row, 1);
                cinema.CinemaUrl = _cineworldHelpers.GetColumnValueAsStringOrEmptyString(row, 2);
                cinema.Address = _cineworldHelpers.GetColumnValueAsStringOrEmptyString(row, 3);
                cinema.Postcode = _cineworldHelpers.GetColumnValueAsStringOrEmptyString(row, 4);
                cinema.Telephone = _cineworldHelpers.GetColumnValueAsStringOrEmptyString(row, 5);
                cinemas.Add(cinema);
            }
            return cinemas;
        }
    }
}
